using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLifeserviceTechnicianQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLifeserviceTechnicianQueryModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("out_technician_ids")]
        [XmlArrayItem("string")]
        public List<string> OutTechnicianIds { get; set; }

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
        /// 蚂蚁门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 手艺人状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("technician_ids")]
        [XmlArrayItem("string")]
        public List<string> TechnicianIds { get; set; }
    }
}
