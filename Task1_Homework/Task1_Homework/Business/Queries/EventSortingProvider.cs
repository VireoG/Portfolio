﻿using System;
using System.Linq.Expressions;

namespace Task1_Homework.Business.Queries
{
    public class EventSortingProvider: BaseSortingProvider<Event>
    {
        protected override Expression<Func<Event, object>> GetSortExpression(PagedData<Event> pagedData)
        {
            return pagedData.SortBy switch
            {
                "Name" => p => p.Name,
                "Date" => p => p.Date,
                _ => p => p.Id
            };
        }
    }
}