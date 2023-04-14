using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CompanyOverviewInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CompanyOverviewInfo : AopObject
    {
        /// <summary>
        /// 资产
        /// </summary>
        [XmlArray("assets")]
        [XmlArrayItem("company_overview_line_info")]
        public List<CompanyOverviewLineInfo> Assets { get; set; }

        /// <summary>
        /// 背景
        /// </summary>
        [XmlArray("background")]
        [XmlArrayItem("company_overview_line_info")]
        public List<CompanyOverviewLineInfo> Background { get; set; }

        /// <summary>
        /// 评价
        /// </summary>
        [XmlArray("evaluate")]
        [XmlArrayItem("company_overview_line_info")]
        public List<CompanyOverviewLineInfo> Evaluate { get; set; }

        /// <summary>
        /// 融资
        /// </summary>
        [XmlArray("financing")]
        [XmlArrayItem("company_overview_line_info")]
        public List<CompanyOverviewLineInfo> Financing { get; set; }

        /// <summary>
        /// 经营
        /// </summary>
        [XmlArray("management")]
        [XmlArrayItem("company_overview_line_info")]
        public List<CompanyOverviewLineInfo> Management { get; set; }

        /// <summary>
        /// 风险
        /// </summary>
        [XmlArray("risk")]
        [XmlArrayItem("company_overview_line_info")]
        public List<CompanyOverviewLineInfo> Risk { get; set; }
    }
}
