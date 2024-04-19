using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupGroupinfoCreateResponse.
    /// </summary>
    public class AlipayMerchantGroupGroupinfoCreateResponse : AopResponse
    {
        /// <summary>
        /// 群组id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }
    }
}
