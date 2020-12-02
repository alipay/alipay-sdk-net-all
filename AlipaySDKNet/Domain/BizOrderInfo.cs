using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BizOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BizOrderInfo : AopObject
    {
        /// <summary>
        /// 订单金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 订单扩展参数
        /// </summary>
        [XmlElement("ext_params")]
        public BizExtInfo ExtParams { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 卖家id
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }
    }
}
