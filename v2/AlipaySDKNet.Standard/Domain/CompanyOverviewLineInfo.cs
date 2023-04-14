using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CompanyOverviewLineInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CompanyOverviewLineInfo : AopObject
    {
        /// <summary>
        /// 行文本。企业某个维度的描述
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 高亮文本列表
        /// </summary>
        [XmlArray("high_light_model_list")]
        [XmlArrayItem("company_overview_high_light")]
        public List<CompanyOverviewHighLight> HighLightModelList { get; set; }
    }
}
