using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaidOuterCardCycleSellConfDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PaidOuterCardCycleSellConfDTO : AopObject
    {
        /// <summary>
        /// 用户开通连续购买地址
        /// </summary>
        [XmlElement("cycle_selling_url")]
        public string CycleSellingUrl { get; set; }

        /// <summary>
        /// 周期购买类型。枚举如下： YEAR 年 QUARTER 季度 MONTH 月
        /// </summary>
        [XmlArray("cycle_type")]
        [XmlArrayItem("string")]
        public List<string> CycleType { get; set; }

        /// <summary>
        /// 是否支持用户连续购买。true代表支持，false代表不支持。
        /// </summary>
        [XmlElement("support_cycle_sell")]
        public bool SupportCycleSell { get; set; }
    }
}
