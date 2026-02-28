using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLifeserviceTechnicianDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLifeserviceTechnicianDeleteModel : AopObject
    {
        /// <summary>
        /// 三方手艺人id【需保证唯一性】
        /// </summary>
        [XmlElement("out_technician_id")]
        public string OutTechnicianId { get; set; }

        /// <summary>
        /// 蚂蚁门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 手艺人id【和out_technician_id二选一】
        /// </summary>
        [XmlElement("technician_id")]
        public string TechnicianId { get; set; }
    }
}
