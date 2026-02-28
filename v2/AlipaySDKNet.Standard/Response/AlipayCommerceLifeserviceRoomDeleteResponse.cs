using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLifeserviceRoomDeleteResponse.
    /// </summary>
    public class AlipayCommerceLifeserviceRoomDeleteResponse : AopResponse
    {
        /// <summary>
        /// 场地id
        /// </summary>
        [XmlElement("room_id")]
        public string RoomId { get; set; }
    }
}
