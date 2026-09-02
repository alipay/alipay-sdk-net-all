using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExaminationEventParam Data Structure.
    /// </summary>
    [Serializable]
    public class ExaminationEventParam : AopObject
    {
        /// <summary>
        /// 预约时间信息 event_type=bookTimeChanged 时有值
        /// </summary>
        [XmlElement("book_time")]
        public BookTimeParam BookTime { get; set; }

        /// <summary>
        /// 检查单号
        /// </summary>
        [XmlElement("check_no")]
        public string CheckNo { get; set; }
    }
}
