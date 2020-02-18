using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceLbsDiscountBatchqueryResponse.
    /// </summary>
    public class AlipayDataDataserviceLbsDiscountBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 广告投放出去的商品信息
        /// </summary>
        [XmlArray("discounts")]
        [XmlArrayItem("antlbs_k_b_discount_info")]
        public List<AntlbsKBDiscountInfo> Discounts { get; set; }
    }
}
