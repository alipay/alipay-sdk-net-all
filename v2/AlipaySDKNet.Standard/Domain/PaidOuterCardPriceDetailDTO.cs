using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaidOuterCardPriceDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PaidOuterCardPriceDetailDTO : AopObject
    {
        /// <summary>
        /// 方案描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 售卖具体金额。单位为元。支持两位小数。
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 售卖金额类型。目前支持 FIXED：固定金额
        /// </summary>
        [XmlElement("price_type")]
        public string PriceType { get; set; }

        /// <summary>
        /// 价值。单位为元。支持两位小数
        /// </summary>
        [XmlElement("worth")]
        public string Worth { get; set; }
    }
}
