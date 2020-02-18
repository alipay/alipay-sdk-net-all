using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossOrderApplyResponse.
    /// </summary>
    public class AlipayBossOrderApplyResponse : AopResponse
    {
        /// <summary>
        /// 订单信息
        /// </summary>
        [XmlElement("order_info")]
        public string OrderInfo { get; set; }
    }
}
