using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BookTimeParam Data Structure.
    /// </summary>
    [Serializable]
    public class BookTimeParam : AopObject
    {
        /// <summary>
        /// 修改后的预约结束时间 yyyy-MM-dd HH:mm:ss格式
        /// </summary>
        [XmlElement("book_end_time")]
        public string BookEndTime { get; set; }

        /// <summary>
        /// 修改后的预约开始时间 yyyy-MM-dd HH:mm:ss格式
        /// </summary>
        [XmlElement("book_start_time")]
        public string BookStartTime { get; set; }
    }
}
