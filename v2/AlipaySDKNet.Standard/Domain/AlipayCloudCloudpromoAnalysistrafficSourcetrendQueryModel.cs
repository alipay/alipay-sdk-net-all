using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoAnalysistrafficSourcetrendQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoAnalysistrafficSourcetrendQueryModel : AopObject
    {
        /// <summary>
        /// 经营分析、经营概况模块公用入参
        /// </summary>
        [XmlElement("common_request")]
        public OpenApiAnalysisCommonRequest CommonRequest { get; set; }

        /// <summary>
        /// 一级来源渠道
        /// </summary>
        [XmlArray("first_source_type")]
        [XmlArrayItem("string")]
        public List<string> FirstSourceType { get; set; }

        /// <summary>
        /// 二级来源渠道
        /// </summary>
        [XmlArray("second_source_type")]
        [XmlArrayItem("string")]
        public List<string> SecondSourceType { get; set; }
    }
}
