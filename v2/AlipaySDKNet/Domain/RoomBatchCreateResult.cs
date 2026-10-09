using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RoomBatchCreateResult Data Structure.
    /// </summary>
    [Serializable]
    public class RoomBatchCreateResult : AopObject
    {
        /// <summary>
        /// 失败编码
        /// </summary>
        [XmlElement("fail_code")]
        public string FailCode { get; set; }

        /// <summary>
        /// 失败描述
        /// </summary>
        [XmlElement("fail_msg")]
        public string FailMsg { get; set; }

        /// <summary>
        /// 外部房间号
        /// </summary>
        [XmlElement("out_room_id")]
        public string OutRoomId { get; set; }

        /// <summary>
        /// 小区id加上外部房间号
        /// </summary>
        [XmlElement("room_id")]
        public string RoomId { get; set; }
    }
}
