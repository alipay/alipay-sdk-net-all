using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VcpDiscountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VcpDiscountInfo : AopObject
    {
        /// <summary>
        /// 计算规则列表
        /// </summary>
        [XmlArray("calc_rules")]
        [XmlArrayItem("vcp_calc_rule")]
        public List<VcpCalcRule> CalcRules { get; set; }

        /// <summary>
        /// 计算类型
        /// </summary>
        [XmlElement("calc_type_mode")]
        public string CalcTypeMode { get; set; }

        /// <summary>
        /// 封顶金额
        /// </summary>
        [XmlElement("ceiling_amount")]
        public string CeilingAmount { get; set; }

        /// <summary>
        /// 跨sku封顶件数
        /// </summary>
        [XmlElement("ceiling_count")]
        public long CeilingCount { get; set; }

        /// <summary>
        /// 优惠类型
        /// </summary>
        [XmlElement("discount_type")]
        public string DiscountType { get; set; }
    }
}
