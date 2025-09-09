using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpInteopOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpInteopOrderCreateModel : AopObject
    {
        /// <summary>
        /// 账号
        /// </summary>
        [XmlElement("account")]
        public string Account { get; set; }

        /// <summary>
        /// 服务市场订单号
        /// </summary>
        [XmlElement("service_market_order_no")]
        public string ServiceMarketOrderNo { get; set; }
    }
}
