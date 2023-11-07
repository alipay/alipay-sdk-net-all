using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemPackage Data Structure.
    /// </summary>
    [Serializable]
    public class ItemPackage : AopObject
    {
        /// <summary>
        /// 商品编码
        /// </summary>
        [XmlElement("commodity_code")]
        public string CommodityCode { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("commodity_name")]
        public string CommodityName { get; set; }

        /// <summary>
        /// 商品可购买周期数量
        /// </summary>
        [XmlElement("effective_period_num")]
        public long EffectivePeriodNum { get; set; }

        /// <summary>
        /// 商品可购买周期类型
        /// </summary>
        [XmlElement("effective_period_type")]
        public string EffectivePeriodType { get; set; }

        /// <summary>
        /// 商品规格编码
        /// </summary>
        [XmlElement("spec_code")]
        public string SpecCode { get; set; }

        /// <summary>
        /// 商品规格名称
        /// </summary>
        [XmlElement("spec_name")]
        public string SpecName { get; set; }
    }
}
