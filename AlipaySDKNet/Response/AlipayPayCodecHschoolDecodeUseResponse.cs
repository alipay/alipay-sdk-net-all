using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayCodecHschoolDecodeUseResponse.
    /// </summary>
    public class AlipayPayCodecHschoolDecodeUseResponse : AopResponse
    {
        /// <summary>
        /// 学生短号
        /// </summary>
        [XmlElement("feature_code")]
        public string FeatureCode { get; set; }

        /// <summary>
        /// 红码 : "red"  黄码 :"yellow"  绿码 : "green" 审核中 :  "init" 未找到  : "notFound"
        /// </summary>
        [XmlElement("health_status")]
        public string HealthStatus { get; set; }

        /// <summary>
        /// 学校编号（外标）
        /// </summary>
        [XmlElement("school_std_code")]
        public string SchoolStdCode { get; set; }

        /// <summary>
        /// 学号
        /// </summary>
        [XmlElement("student_no")]
        public string StudentNo { get; set; }
    }
}
