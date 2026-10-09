using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MultiDimAuthAmountQuery Data Structure.
    /// </summary>
    [Serializable]
    public class MultiDimAuthAmountQuery : AopObject
    {
        /// <summary>
        /// 具体的查询的场景信息，如特付查询场景
        /// </summary>
        [XmlElement("auth_biz_type")]
        public string AuthBizType { get; set; }

        /// <summary>
        /// 查询的具体维度条件
        /// </summary>
        [XmlArray("dim_conditions")]
        [XmlArrayItem("condition_entry")]
        public List<ConditionEntry> DimConditions { get; set; }

        /// <summary>
        /// 蚁符具体的规则包编码信息
        /// </summary>
        [XmlElement("package_code")]
        public string PackageCode { get; set; }
    }
}
