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
        /// se设备uuid（16进制的字符串，没有0x前缀）
        /// </summary>
        [XmlElement("se_uuid")]
        public string SeUuid { get; set; }

        /// <summary>
        /// 设备的tagid
        /// </summary>
        [XmlElement("tag_id")]
        public string TagId { get; set; }
    }
}
