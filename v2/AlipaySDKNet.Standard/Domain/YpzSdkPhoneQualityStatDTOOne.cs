using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// YpzSdkPhoneQualityStatDTOOne Data Structure.
    /// </summary>
    [Serializable]
    public class YpzSdkPhoneQualityStatDTOOne : AopObject
    {
        /// <summary>
        /// 事件名称
        /// </summary>
        [XmlElement("event_name")]
        public string EventName { get; set; }

        /// <summary>
        /// 事件发生时间
        /// </summary>
        [XmlElement("event_occur_time")]
        public string EventOccurTime { get; set; }

        /// <summary>
        /// 事件类型
        /// </summary>
        [XmlElement("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// 医疗机构名称
        /// </summary>
        [XmlElement("medical_institution_name")]
        public string MedicalInstitutionName { get; set; }

        /// <summary>
        /// 合格的数据量占比
        /// </summary>
        [XmlElement("pass_rate")]
        public string PassRate { get; set; }

        /// <summary>
        /// 手机号有问题的数据量统计
        /// </summary>
        [XmlElement("problem_count")]
        public string ProblemCount { get; set; }

        /// <summary>
        /// 手机号有问题的数据量占比
        /// </summary>
        [XmlElement("problem_rate")]
        public string ProblemRate { get; set; }

        /// <summary>
        /// 报告出具事件的数据量统计
        /// </summary>
        [XmlElement("total_count")]
        public string TotalCount { get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [XmlElement("uscc")]
        public string Uscc { get; set; }
    }
}
