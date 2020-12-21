using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreditBankTraining Data Structure.
    /// </summary>
    [Serializable]
    public class CreditBankTraining : AopObject
    {
        /// <summary>
        /// 获取时间，格式yyyy-mm-dd HH:mm:ss
        /// </summary>
        [XmlElement("experience_time")]
        public string ExperienceTime { get; set; }

        /// <summary>
        /// 是否有证，枚举1是2否
        /// </summary>
        [XmlElement("have_project_certificate")]
        public long HaveProjectCertificate { get; set; }

        /// <summary>
        /// 办学机构
        /// </summary>
        [XmlElement("inst_name")]
        public string InstName { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [XmlElement("project_name")]
        public string ProjectName { get; set; }

        /// <summary>
        /// 培训id
        /// </summary>
        [XmlElement("training_outer_id")]
        public string TrainingOuterId { get; set; }
    }
}
