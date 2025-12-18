using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RoomDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RoomDetailInfo : AopObject
    {
        /// <summary>
        /// 房间面积，单位为平方米
        /// </summary>
        [XmlElement("area")]
        public string Area { get; set; }

        /// <summary>
        /// 床型描述
        /// </summary>
        [XmlElement("bed_desc")]
        public string BedDesc { get; set; }

        /// <summary>
        /// 房间能够入住的最大人数，有效正整数
        /// </summary>
        [XmlElement("capacity")]
        public string Capacity { get; set; }

        /// <summary>
        /// 房间楼层信息
        /// </summary>
        [XmlElement("floor")]
        public string Floor { get; set; }
    }
}
