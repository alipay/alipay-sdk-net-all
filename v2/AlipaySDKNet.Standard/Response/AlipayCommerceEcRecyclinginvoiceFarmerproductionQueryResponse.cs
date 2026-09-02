using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceFarmerproductionQueryResponse.
    /// </summary>
    public class AlipayCommerceEcRecyclinginvoiceFarmerproductionQueryResponse : AopResponse
    {
        /// <summary>
        /// 产量记录列表
        /// </summary>
        [XmlArray("farmer_item_list")]
        [XmlArrayItem("recycling_farmer_item_result")]
        public List<RecyclingFarmerItemResult> FarmerItemList { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
