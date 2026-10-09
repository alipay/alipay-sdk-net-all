using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FlightPromotionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FlightPromotionInfo : AopObject
    {
        /// <summary>
        /// 币种代码
        /// </summary>
        [XmlElement("amount_currency")]
        public string AmountCurrency { get; set; }

        /// <summary>
        /// 优惠名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 单位：分
        /// </summary>
        [XmlElement("promotion_amount_cent")]
        public long PromotionAmountCent { get; set; }

        /// <summary>
        /// ASSETS：带资 NOT_ASSETS:不带资
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
