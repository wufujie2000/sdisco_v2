﻿using Abp.Application.Services.Dto;
using System;

namespace TepayLink.Sdisco.Bookings.Dtos
{
    public class GetAllBookingsForExcelInput
    {
		public string Filter { get; set; }

		public int StatusFilter { get; set; }


		 public string ProductNameFilter { get; set; }

		 
    }
}