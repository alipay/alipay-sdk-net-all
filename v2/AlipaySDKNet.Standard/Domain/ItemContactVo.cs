using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemContactVo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemContactVo : AopObject
    {
        /// <summary>
        /// 事项咨询方式，自定义内容：电话、邮箱、手机等
        /// </summary>
        [XmlElement("consultation_mode")]
        public string ConsultationMode { get; set; }

        /// <summary>
        /// 事项办事地点
        /// </summary>
        [XmlElement("location")]
        public string Location { get; set; }

        /// <summary>
        /// 事项办理时间
        /// </summary>
        [XmlElement("processing_time")]
        public string ProcessingTime { get; set; }
    }
}
