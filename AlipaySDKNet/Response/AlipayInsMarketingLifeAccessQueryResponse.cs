using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsMarketingLifeAccessQueryResponse.
    /// </summary>
    public class AlipayInsMarketingLifeAccessQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否准入
        /// </summary>
        [XmlElement("access")]
        public bool Access { get; set; }
    }
}
