using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLifeserviceItembookingBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLifeserviceItembookingBindModel : AopObject
    {
        /// <summary>
        /// 商品编码
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("room_ids")]
        [XmlArrayItem("string")]
        public List<string> RoomIds { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("service_ids")]
        [XmlArrayItem("string")]
        public List<string> ServiceIds { get; set; }

        /// <summary>
        /// sku编码
        /// </summary>
        [XmlElement("sku_code")]
        public string SkuCode { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("technician_ids")]
        [XmlArrayItem("string")]
        public List<string> TechnicianIds { get; set; }
    }
}
