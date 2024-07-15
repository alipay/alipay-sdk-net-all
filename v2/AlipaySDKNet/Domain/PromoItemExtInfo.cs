using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromoItemExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PromoItemExtInfo : AopObject
    {
        /// <summary>
        /// 商品补贴金额（单位 元）：淘宝、1688 针对单品的支付宝渠道补贴金额
        /// </summary>
        [XmlElement("out_single_subsidy")]
        public string OutSingleSubsidy { get; set; }
    }
}
