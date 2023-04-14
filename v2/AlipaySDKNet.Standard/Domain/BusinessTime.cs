using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusinessTime Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessTime : AopObject
    {
        /// <summary>
        /// 营业时间段中暂停营业时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 营业时间段中开始营业时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
