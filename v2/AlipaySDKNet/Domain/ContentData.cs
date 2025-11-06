using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContentData Data Structure.
    /// </summary>
    [Serializable]
    public class ContentData : AopObject
    {
        /// <summary>
        /// 健康史
        /// </summary>
        [XmlElement("health_history")]
        public HealthHistory HealthHistory { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("health_report_list")]
        [XmlArrayItem("health_report")]
        public List<HealthReport> HealthReportList { get; set; }

        /// <summary>
        /// 用户资料
        /// </summary>
        [XmlElement("user_folder")]
        public HealthcareData UserFolder { get; set; }

        /// <summary>
        /// 个人信息
        /// </summary>
        [XmlElement("userbase")]
        public Userbase Userbase { get; set; }
    }
}
