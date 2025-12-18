using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceActivityDiscountQueryResponse.
    /// </summary>
    public class AlipayCommerceActivityDiscountQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("discount_activity_info_list")]
        [XmlArrayItem("activity_discount_info")]
        public List<ActivityDiscountInfo> DiscountActivityInfoList { get; set; }
    }
}
