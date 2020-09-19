using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayApplepayTransactionauthtokenDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayApplepayTransactionauthtokenDeleteModel : AopObject
    {
        /// <summary>
        /// 设备id
        /// </summary>
        [XmlElement("device_identifier")]
        public string DeviceIdentifier { get; set; }

        /// <summary>
        /// 卡id
        /// </summary>
        [XmlElement("provisioning_bundle_identifier")]
        public string ProvisioningBundleIdentifier { get; set; }

        /// <summary>
        /// 卡id列表
        /// </summary>
        [XmlArray("provisioning_bundle_identifiers")]
        [XmlArrayItem("string")]
        public List<string> ProvisioningBundleIdentifiers { get; set; }

        /// <summary>
        /// 推送通知token
        /// </summary>
        [XmlElement("push_token")]
        public string PushToken { get; set; }

        /// <summary>
        /// uid
        /// </summary>
        [XmlElement("reference_identifier")]
        public string ReferenceIdentifier { get; set; }
    }
}
