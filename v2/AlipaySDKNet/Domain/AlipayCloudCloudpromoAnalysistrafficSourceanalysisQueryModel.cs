using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoAnalysistrafficSourceanalysisQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoAnalysistrafficSourceanalysisQueryModel : AopObject
    {
        /// <summary>
        /// 经营分析、经营概况模块公用入参
        /// </summary>
        [XmlElement("common_request")]
        public OpenApiAnalysisCommonRequest CommonRequest { get; set; }

        /// <summary>
        /// 此接口必须与参数trend同时使用，且trend 为true的时候
        /// </summary>
        [XmlArray("first_source_type")]
        [XmlArrayItem("string")]
        public List<string> FirstSourceType { get; set; }

        /// <summary>
        /// 此接口必须搭配 trend==true的时候传入，如果没有可以省略
        /// </summary>
        [XmlArray("second_source_type")]
        [XmlArrayItem("string")]
        public List<string> SecondSourceType { get; set; }

        /// <summary>
        /// 默认不传为false，需要查询趋势图 为true，在此接口需要搭配 一级、二级来源渠道入参使用
        /// </summary>
        [XmlElement("trend")]
        public bool Trend { get; set; }
    }
}
