using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScheduleWorkResult Data Structure.
    /// </summary>
    [Serializable]
    public class ScheduleWorkResult : AopObject
    {
        /// <summary>
        /// 返回码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("data")]
        public ScheduleWorkItems Data { get; set; }

        /// <summary>
        /// 返回码描述
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
