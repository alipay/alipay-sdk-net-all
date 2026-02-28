using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLifeserviceRoomQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLifeserviceRoomQueryModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("out_room_ids")]
        [XmlArrayItem("string")]
        public List<string> OutRoomIds { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("room_ids")]
        [XmlArrayItem("string")]
        public List<string> RoomIds { get; set; }

        /// <summary>
        /// 蚂蚁门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// active 可预约状态 inactive 不可预约状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
