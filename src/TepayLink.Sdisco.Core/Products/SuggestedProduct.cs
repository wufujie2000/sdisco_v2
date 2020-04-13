﻿using TepayLink.Sdisco.Products;
using TepayLink.Sdisco.Products;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using Abp.Domain.Entities;

namespace TepayLink.Sdisco.Products
{
	[Table("SuggestedProducts")]
    public class SuggestedProduct : AuditedEntity<long> , IMayHaveTenant
    {
			public int? TenantId { get; set; }
			


		public virtual long ProductId { get; set; }
		
        [ForeignKey("ProductId")]
		public Product ProductFk { get; set; }
		
		public virtual long? SuggestedProductId { get; set; }
		
        [ForeignKey("SuggestedProductId")]
		public Product SuggestedProductFk { get; set; }
		
    }
}