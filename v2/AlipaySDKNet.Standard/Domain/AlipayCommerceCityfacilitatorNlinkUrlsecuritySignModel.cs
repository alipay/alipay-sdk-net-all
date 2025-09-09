using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorNlinkUrlsecuritySignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCityfacilitatorNlinkUrlsecuritySignModel : AopObject
    {
        /// <summary>
        /// 模块item_id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// se设备uuid（16进制的字符串，没有0x前缀）
        /// </summary>
        [XmlElement("se_uuid")]
        public string SeUuid { get; set; }

        /// <summary>
        /// 模块sn
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 厂商id
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }

        /// <summary>
        /// 设备的tagid
        /// </summary>
        [XmlElement("tag_id")]
        public string TagId { get; set; }
    }
}
