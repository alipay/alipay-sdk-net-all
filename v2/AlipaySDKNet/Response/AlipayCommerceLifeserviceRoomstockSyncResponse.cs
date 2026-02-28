using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLifeserviceRoomstockSyncResponse.
    /// </summary>
    public class AlipayCommerceLifeserviceRoomstockSyncResponse : AopResponse
    {
        /// <summary>
        /// 场地id
        /// </summary>
        [XmlElement("room_id")]
        public string RoomId { get; set; }
    }
}
