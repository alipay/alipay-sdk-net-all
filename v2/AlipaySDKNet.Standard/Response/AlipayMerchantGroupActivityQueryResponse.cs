using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupActivityQueryResponse.
    /// </summary>
    public class AlipayMerchantGroupActivityQueryResponse : AopResponse
    {
        /// <summary>
        /// 商家群活动详情
        /// </summary>
        [XmlElement("activity_detail")]
        public GroupActivityDetailVO ActivityDetail { get; set; }
    }
}
