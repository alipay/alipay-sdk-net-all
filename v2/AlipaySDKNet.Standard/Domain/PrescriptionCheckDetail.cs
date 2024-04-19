using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PrescriptionCheckDetail Data Structure.
    /// </summary>
    [Serializable]
    public class PrescriptionCheckDetail : AopObject
    {
        /// <summary>
        /// 校验编码
        /// </summary>
        [XmlElement("check_code")]
        public string CheckCode { get; set; }

        /// <summary>
        /// 校验内容
        /// </summary>
        [XmlElement("check_content")]
        public string CheckContent { get; set; }

        /// <summary>
        /// 校验标题
        /// </summary>
        [XmlElement("check_title")]
        public string CheckTitle { get; set; }

        /// <summary>
        /// 推荐的处方
        /// </summary>
        [XmlArray("recommended_diagnosis_list")]
        [XmlArrayItem("diagnosis")]
        public List<Diagnosis> RecommendedDiagnosisList { get; set; }

        /// <summary>
        /// SUGGESTION： 建议解决 REQUIRED：必须解决
        /// </summary>
        [XmlElement("solve_level")]
        public string SolveLevel { get; set; }
    }
}
