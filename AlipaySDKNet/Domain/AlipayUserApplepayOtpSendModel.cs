using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserApplepayOtpSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserApplepayOtpSendModel : AopObject
    {
        /// <summary>
        /// 卡id(由固定前缀+32位数字构成)
        /// </summary>
        [XmlElement("provisioning_bundle_identifier")]
        public string ProvisioningBundleIdentifier { get; set; }

        /// <summary>
        /// 校验方法标识
        /// </summary>
        [XmlElement("resolution_method_identifier")]
        public string ResolutionMethodIdentifier { get; set; }
    }
}
