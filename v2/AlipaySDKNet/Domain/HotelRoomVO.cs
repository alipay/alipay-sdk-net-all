using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HotelRoomVO Data Structure.
    /// </summary>
    [Serializable]
    public class HotelRoomVO : AopObject
    {
        /// <summary>
        /// 楼栋
        /// </summary>
        [XmlElement("build")]
        public string Build { get; set; }

        /// <summary>
        /// 特色标签标签数量最多8，单标签字数最多4例：安静，海景
        /// </summary>
        [XmlArray("feature_tag_list")]
        [XmlArrayItem("string")]
        public List<string> FeatureTagList { get; set; }

        /// <summary>
        /// 楼层
        /// </summary>
        [XmlElement("floor")]
        public string Floor { get; set; }

        /// <summary>
        /// 房间大小，单位 平米
        /// </summary>
        [XmlElement("room_area")]
        public string RoomArea { get; set; }

        /// <summary>
        /// 房间号
        /// </summary>
        [XmlElement("room_no")]
        public string RoomNo { get; set; }
    }
}
