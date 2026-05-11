using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeCreditOrderPayResponse.
    /// </summary>
    public class AlipayTradeCreditOrderPayResponse : AopResponse
    {
        /// <summary>
        /// 订单串，用于客户端唤起收银台
        /// </summary>
        [XmlElement("order_str")]
        public string OrderStr { get; set; }
    }
}
