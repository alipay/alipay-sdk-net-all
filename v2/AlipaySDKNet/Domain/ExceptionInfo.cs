using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExceptionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ExceptionInfo : AopObject
    {
        /// <summary>
        /// 任务执行过程中设备出现的异常
        /// </summary>
        [XmlElement("exp_code")]
        public string ExpCode { get; set; }

        /// <summary>
        /// 任务执行过程中设备异常发生的时间
        /// </summary>
        [XmlElement("exp_time")]
        public string ExpTime { get; set; }
    }
}
