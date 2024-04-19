using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserApplepayProvisioningbundleModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserApplepayProvisioningbundleModifyModel : AopObject
    {
        /// <summary>
        /// 管理动作
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// otp的值
        /// </summary>
        [XmlElement("otp_value")]
        public string OtpValue { get; set; }

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
