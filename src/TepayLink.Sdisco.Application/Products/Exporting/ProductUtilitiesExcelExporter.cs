﻿using System.Collections.Generic;
using Abp.Runtime.Session;
using Abp.Timing.Timezone;
using TepayLink.Sdisco.DataExporting.Excel.EpPlus;
using TepayLink.Sdisco.Products.Dtos;
using TepayLink.Sdisco.Dto;
using TepayLink.Sdisco.Storage;

namespace TepayLink.Sdisco.Products.Exporting
{
    public class ProductUtilitiesExcelExporter : EpPlusExcelExporterBase, IProductUtilitiesExcelExporter
    {

        private readonly ITimeZoneConverter _timeZoneConverter;
        private readonly IAbpSession _abpSession;

        public ProductUtilitiesExcelExporter(
            ITimeZoneConverter timeZoneConverter,
            IAbpSession abpSession,
			ITempFileCacheManager tempFileCacheManager) :  
	base(tempFileCacheManager)
        {
            _timeZoneConverter = timeZoneConverter;
            _abpSession = abpSession;
        }

        public FileDto ExportToFile(List<GetProductUtilityForViewDto> productUtilities)
        {
            return CreateExcelPackage(
                "ProductUtilities.xlsx",
                excelPackage =>
                {
                    var sheet = excelPackage.Workbook.Worksheets.Add(L("ProductUtilities"));
                    sheet.OutLineApplyStyle = true;

                    AddHeader(
                        sheet,
                        (L("Product")) + L("Name"),
                        (L("Utility")) + L("Name")
                        );

                    AddObjects(
                        sheet, 2, productUtilities,
                        _ => _.ProductName,
                        _ => _.UtilityName
                        );

					

                });
        }
    }
}