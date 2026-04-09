using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemProjectList Data Structure.
    /// </summary>
    [Serializable]
    public class ItemProjectList : AopObject
    {
        /// <summary>
        /// 检查结果
        /// </summary>
        [XmlElement("check_result")]
        public string CheckResult { get; set; }

        /// <summary>
        /// 指标范围
        /// </summary>
        [XmlElement("indicators_range")]
        public string IndicatorsRange { get; set; }

        /// <summary>
        /// 指标单位。
        /// </summary>
        [XmlElement("indicators_unit")]
        public string IndicatorsUnit { get; set; }

        /// <summary>
        /// 项目编码
        /// </summary>
        [XmlElement("project_code")]
        public string ProjectCode { get; set; }

        /// <summary>
        /// 项目名
        /// </summary>
        [XmlElement("project_name")]
        public string ProjectName { get; set; }
    }
}
