using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NetFlowOfferInfo Data Structure.
    /// </summary>
    [Serializable]
    public class NetFlowOfferInfo : AopObject
    {
        /// <summary>
        /// 流量生效时间
        /// </summary>
        [XmlElement("effective_time")]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// 流量过期时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 流量套餐名称
        /// </summary>
        [XmlElement("offer_name")]
        public string OfferName { get; set; }

        /// <summary>
        /// 下单时间
        /// </summary>
        [XmlElement("order_time")]
        public string OrderTime { get; set; }
    }
}
