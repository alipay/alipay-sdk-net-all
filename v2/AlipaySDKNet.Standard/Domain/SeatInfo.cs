using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SeatInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SeatInfo : AopObject
    {
        /// <summary>
        /// 座位等级
        /// </summary>
        [XmlElement("seat_class")]
        public string SeatClass { get; set; }

        /// <summary>
        /// 座位号
        /// </summary>
        [XmlElement("seat_no")]
        public string SeatNo { get; set; }
    }
}
