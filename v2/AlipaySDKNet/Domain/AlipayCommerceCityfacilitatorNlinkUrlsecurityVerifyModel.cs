using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorNlinkUrlsecurityVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCityfacilitatorNlinkUrlsecurityVerifyModel : AopObject
    {
        /// <summary>
        /// 设备生成的签名
        /// </summary>
        [XmlElement("device_sign")]
        public string DeviceSign { get; set; }

        /// <summary>
        /// mcu的uuid
        /// </summary>
        [XmlElement("mcu_uuid")]
        public string McuUuid { get; set; }

        /// <summary>
        /// 设备生成的公钥,64字节
        /// </summary>
        [XmlElement("public_key")]
        public string PublicKey { get; set; }

        /// <summary>
        /// se设备uuid（16进制的字符串，没有0x前缀）
        /// </summary>
        [XmlElement("se_uuid")]
        public string SeUuid { get; set; }

        /// <summary>
        /// 厂商id
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }
    }
}
