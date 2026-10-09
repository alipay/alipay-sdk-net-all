using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppCommunityRoomBatchcreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppCommunityRoomBatchcreateModel : AopObject
    {
        /// <summary>
        /// 小区名字拼音首字母大写+YYYYMMDD+防重位
        /// </summary>
        [XmlElement("community_short_name")]
        public string CommunityShortName { get; set; }

        /// <summary>
        /// |隔开。例如: 1栋|2单元
        /// </summary>
        [XmlElement("parent_value")]
        public string ParentValue { get; set; }

        /// <summary>
        /// 房间集合
        /// </summary>
        [XmlArray("rooms")]
        [XmlArrayItem("room_batch_create_item")]
        public List<RoomBatchCreateItem> Rooms { get; set; }
    }
}
