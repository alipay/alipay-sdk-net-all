using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLifeserviceBookingSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLifeserviceBookingSyncModel : AopObject
    {
        /// <summary>
        /// 操作动作
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("booking_attr")]
        [XmlArrayItem("life_service_attr")]
        public List<LifeServiceAttr> BookingAttr { get; set; }

        /// <summary>
        /// 预约单id
        /// </summary>
        [XmlElement("booking_id")]
        public string BookingId { get; set; }

        /// <summary>
        /// 蚂蚁门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
