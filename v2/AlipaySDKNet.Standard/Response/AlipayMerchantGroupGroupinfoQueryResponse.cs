using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupGroupinfoQueryResponse.
    /// </summary>
    public class AlipayMerchantGroupGroupinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 群组详情信息。
        /// </summary>
        [XmlElement("group_detail")]
        public GroupDetailVO GroupDetail { get; set; }
    }
}
