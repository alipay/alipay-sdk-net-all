using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneFinresearchCopilotConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneFinresearchCopilotConsultModel : AopObject
    {
        /// <summary>
        /// 咨询补充信息
        /// </summary>
        [XmlElement("consult_param")]
        public string ConsultParam { get; set; }

        /// <summary>
        /// 提问类型
        /// </summary>
        [XmlElement("consult_type")]
        public string ConsultType { get; set; }

        /// <summary>
        /// 分析结束时间，决定了分析内容的时间段
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 提问内容
        /// </summary>
        [XmlElement("question")]
        public string Question { get; set; }

        /// <summary>
        /// 问题分析开始时间，决定了分析内容的时间段
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
