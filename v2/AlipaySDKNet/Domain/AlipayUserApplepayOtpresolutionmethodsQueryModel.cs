using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserApplepayOtpresolutionmethodsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserApplepayOtpresolutionmethodsQueryModel : AopObject
    {
        /// <summary>
        /// 卡id(由固定前缀+32位数字构成)
        /// </summary>
        [XmlElement("provisioning_bundle_identifier")]
        public string ProvisioningBundleIdentifier { get; set; }
    }
}
