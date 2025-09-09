using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Shift Data Structure.
    /// </summary>
    [Serializable]
    public class Shift : AopObject
    {
        /// <summary>
        /// 选班时段结束时间
        /// </summary>
        [XmlElement("end")]
        public string End { get; set; }

        /// <summary>
        /// 选班时段唯一标识
        /// </summary>
        [XmlElement("shift_id")]
        public string ShiftId { get; set; }

        /// <summary>
        /// 选班时段开始时间
        /// </summary>
        [XmlElement("start")]
        public string Start { get; set; }
    }
}
