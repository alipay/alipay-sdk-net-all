using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NfcDeviceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class NfcDeviceInfo : AopObject
    {
        /// <summary>
        /// 设备号
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备类型：N7：N7，蓝环：BLUE_COIL，音箱：SPEAKER
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 平台侧商户号
        /// </summary>
        [XmlElement("merchant_no")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 商户类型
        /// </summary>
        [XmlElement("merchant_type")]
        public string MerchantType { get; set; }
    }
}
