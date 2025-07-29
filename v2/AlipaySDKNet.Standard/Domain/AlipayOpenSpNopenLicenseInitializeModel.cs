using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNopenLicenseInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNopenLicenseInitializeModel : AopObject
    {
        /// <summary>
        /// 模组生成的签名
        /// </summary>
        [XmlElement("device_sign")]
        public string DeviceSign { get; set; }

        /// <summary>
        /// 模组的itemId
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// mcu的uuid
        /// </summary>
        [XmlElement("mcu_id")]
        public string McuId { get; set; }

        /// <summary>
        /// 模组生成的公钥,64字节
        /// </summary>
        [XmlElement("public_key")]
        public string PublicKey { get; set; }

        /// <summary>
        /// se的uuid（16进制的字符串，没有0x前缀）
        /// </summary>
        [XmlElement("se_uuid")]
        public string SeUuid { get; set; }

        /// <summary>
        /// 模组sn
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 厂商ID
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }

        /// <summary>
        /// license类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
