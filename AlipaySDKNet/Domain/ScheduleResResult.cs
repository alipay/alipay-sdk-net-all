using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScheduleResResult Data Structure.
    /// </summary>
    [Serializable]
    public class ScheduleResResult : AopObject
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
        public ScheduleResItem Data { get; set; }

        /// <summary>
        /// 返回消息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
