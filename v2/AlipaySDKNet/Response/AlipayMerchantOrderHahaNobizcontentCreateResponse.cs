using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantOrderHahaNobizcontentCreateResponse.
    /// </summary>
    public class AlipayMerchantOrderHahaNobizcontentCreateResponse : AopResponse
    {
        /// <summary>
        /// 出参
        /// </summary>
        [XmlElement("out")]
        public string Out { get; set; }
    }
}
