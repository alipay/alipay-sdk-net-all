using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLifeserviceRoomSyncResponse.
    /// </summary>
    public class AlipayCommerceLifeserviceRoomSyncResponse : AopResponse
    {
        /// <summary>
        /// 场地id
        /// </summary>
        [XmlElement("room_id")]
        public string RoomId { get; set; }
    }
}
