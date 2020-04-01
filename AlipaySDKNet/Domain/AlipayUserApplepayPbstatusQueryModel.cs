using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserApplepayPbstatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserApplepayPbstatusQueryModel : AopObject
    {
        /// <summary>
        /// 设备接受语言
        /// </summary>
        [XmlElement("device_accept_language")]
        public string DeviceAcceptLanguage { get; set; }

        /// <summary>
        /// 卡id(由固定前缀+32位数字构成)
        /// </summary>
        [XmlElement("provisioning_bundle_identifier")]
        public string ProvisioningBundleIdentifier { get; set; }

        /// <summary>
        /// 卡的用户id(由固定前缀+支付宝用户id组成)
        /// </summary>
        [XmlElement("reference_identifier")]
        public string ReferenceIdentifier { get; set; }
    }
}
