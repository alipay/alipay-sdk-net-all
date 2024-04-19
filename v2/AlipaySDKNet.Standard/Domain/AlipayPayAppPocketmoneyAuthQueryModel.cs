using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayAppPocketmoneyAuthQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayAppPocketmoneyAuthQueryModel : AopObject
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 厂商家长ID
        /// </summary>
        [XmlElement("vendor_parent_id")]
        public string VendorParentId { get; set; }
    }
}
