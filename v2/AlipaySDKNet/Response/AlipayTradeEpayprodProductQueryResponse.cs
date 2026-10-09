using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeEpayprodProductQueryResponse.
    /// </summary>
    public class AlipayTradeEpayprodProductQueryResponse : AopResponse
    {
        /// <summary>
        /// 产品开通状态
        /// </summary>
        [XmlElement("product_open_status")]
        public string ProductOpenStatus { get; set; }
    }
}
