﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TopMarket.Shared.DTOs
{
    public class FilterProductsDTO
    {
        public int Page { get; set; } = 1;
        public int RecordsPerPage { get; set; } = 10;
        public PaginationDTO Pagination
        {
            get { return new PaginationDTO() { Page = Page, RecordsPerPage = RecordsPerPage }; }
        }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        //public bool InTheaters { get; set; }
        //public bool UpcomingReleases { get; set; }
    }
}
