using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiPassStatus Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiPassStatus : AopObject
    {
        /// <summary>
        /// 卡id(由固定前缀+32位数字构成)
        /// </summary>
        [XmlElement("provisioning_bundle_identifier")]
        public string ProvisioningBundleIdentifier { get; set; }

        /// <summary>
        /// 卡状态
        /// </summary>
        [XmlElement("state")]
        public string State { get; set; }
    }
}
