﻿
namespace Task1_Homework.Business.Queries
{
    public abstract class BaseQuery
    {
        public int TotalNumber { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public string SortBy { get; set; }
        public SortOrder SortOrder { get; set; }
    }
}