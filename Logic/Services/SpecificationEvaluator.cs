﻿using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Services
{
    public class SpecificationEvaluator<T> where T : EntityBase
    {
        public static IQueryable<T> GetQuery(IQueryable<T> inputQuery, ISpecification<T> spec)
        {
            if (spec.Criteria != null)
            {
                inputQuery = inputQuery.Where(spec.Criteria);
            }

            inputQuery = spec.Includes.Aggregate(inputQuery, (current, include) => current.Include(include));
            inputQuery = spec.IncludeStrings.Aggregate(inputQuery, (current, include) => current.Include(include));

            if (spec.OrderBy != null)
            {
                inputQuery = inputQuery.OrderBy(spec.OrderBy);
            }

            if (spec.OrderByDesc != null)
            {
                inputQuery = inputQuery.OrderByDescending(spec.OrderByDesc);
            }


            return inputQuery;
        }
    }
}
