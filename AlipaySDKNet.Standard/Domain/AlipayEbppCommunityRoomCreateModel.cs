using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppCommunityRoomCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppCommunityRoomCreateModel : AopObject
    {
        /// <summary>
        /// 小区短名, 创建小区时生成
        /// </summary>
        [XmlElement("community_short_name")]
        public string CommunityShortName { get; set; }

        /// <summary>
        /// ISV外部房间号, 可空, 创建后已支付宝内部房间号为准
        /// </summary>
        [XmlElement("out_room_id")]
        public string OutRoomId { get; set; }

        /// <summary>
        /// 户主 手机
        /// </summary>
        [XmlElement("owner_mobile")]
        public string OwnerMobile { get; set; }

        /// <summary>
        /// 户主姓名
        /// </summary>
        [XmlElement("owner_name")]
        public string OwnerName { get; set; }

        /// <summary>
        /// 房间结构化描述信息，|隔开。例如：区|栋|单元|室
        /// </summary>
        [XmlElement("room_desc")]
        public string RoomDesc { get; set; }

        /// <summary>
        /// 房间结构化数据信息，|隔开。例如：南|1|2|202
        /// </summary>
        [XmlElement("room_value")]
        public string RoomValue { get; set; }
    }
}
