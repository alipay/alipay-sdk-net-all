using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShiftStockVO Data Structure.
    /// </summary>
    [Serializable]
    public class ShiftStockVO : AopObject
    {
        /// <summary>
        /// 时间段结束毫秒时间戳
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 时间段开始毫秒时间戳
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 库存数量
        /// </summary>
        [XmlElement("stock")]
        public long Stock { get; set; }
    }
}
