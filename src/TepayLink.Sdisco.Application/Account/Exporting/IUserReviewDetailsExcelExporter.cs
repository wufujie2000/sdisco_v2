﻿using System.Collections.Generic;
using TepayLink.Sdisco.Account.Dtos;
using TepayLink.Sdisco.Dto;

namespace TepayLink.Sdisco.Account.Exporting
{
    public interface IUserReviewDetailsExcelExporter
    {
        FileDto ExportToFile(List<GetUserReviewDetailForViewDto> userReviewDetails);
    }
}