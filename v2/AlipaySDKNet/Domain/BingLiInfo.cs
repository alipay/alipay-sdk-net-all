using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BingLiInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BingLiInfo : AopObject
    {
        /// <summary>
        /// 病历中患者年龄，如23岁、2个月、23天等
        /// </summary>
        [XmlElement("age")]
        public string Age { get; set; }

        /// <summary>
        /// 病历中患者出生日期
        /// </summary>
        [XmlElement("birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// 病历中疾病描述
        /// </summary>
        [XmlElement("disease_detail")]
        public string DiseaseDetail { get; set; }

        /// <summary>
        /// 病历中患者疾病
        /// </summary>
        [XmlElement("disease_name")]
        public string DiseaseName { get; set; }

        /// <summary>
        /// 病历中患者性别
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 病历中患者姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 病历图片类型
        /// </summary>
        [XmlElement("report_type")]
        public string ReportType { get; set; }
    }
}
