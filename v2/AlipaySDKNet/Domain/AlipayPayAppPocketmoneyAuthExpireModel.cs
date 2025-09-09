using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayAppPocketmoneyAuthExpireModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayAppPocketmoneyAuthExpireModel : AopObject
    {
        /// <summary>
        /// 设备号，openWatchId
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 兼容设备号，openId
        /// </summary>
        [XmlElement("extra_device_id")]
        public string ExtraDeviceId { get; set; }

        /// <summary>
        /// 厂商名称
        /// </summary>
        [XmlElement("solution_vendor")]
        public string SolutionVendor { get; set; }

        /// <summary>
        /// 厂商管理员id
        /// </summary>
        [XmlElement("vendor_parent_id")]
        public string VendorParentId { get; set; }
    }
}
