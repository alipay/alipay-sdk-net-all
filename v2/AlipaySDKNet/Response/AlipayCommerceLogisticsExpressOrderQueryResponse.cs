using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsExpressOrderQueryResponse.
    /// </summary>
    public class AlipayCommerceLogisticsExpressOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 卡片地址
        /// </summary>
        [XmlElement("card_url")]
        public string CardUrl { get; set; }
    }
}
