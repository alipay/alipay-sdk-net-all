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
        /// 商户支付宝账号。如果作业子项中包含代商户入驻，则不传递此参数
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
