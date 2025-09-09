using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitLuckDrawInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitLuckDrawInfo : AopObject
    {
        /// <summary>
        /// true: 可抽奖 false: 不可抽奖
        /// </summary>
        [XmlElement("can_luck_draw")]
        public bool CanLuckDraw { get; set; }

        /// <summary>
        /// true: 已抽奖 false: 未抽奖
        /// </summary>
        [XmlElement("has_luck_draw")]
        public bool HasLuckDraw { get; set; }

        /// <summary>
        /// 订单信息
        /// </summary>
        [XmlElement("order_info")]
        public BenefitOrderInfo OrderInfo { get; set; }
    }
}
