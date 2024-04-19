using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserApplepayProvisioningbundleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserApplepayProvisioningbundleQueryModel : AopObject
    {
        /// <summary>
        /// 加密证书链
        /// </summary>
        [XmlArray("encryption_cert_chain")]
        [XmlArrayItem("string")]
        public List<string> EncryptionCertChain { get; set; }

        /// <summary>
        /// 加密版本号
        /// </summary>
        [XmlElement("encryption_version")]
        public string EncryptionVersion { get; set; }

        /// <summary>
        /// 风控数据
        /// </summary>
        [XmlElement("fraud_data")]
        public FraudData FraudData { get; set; }

        /// <summary>
        /// 地区
        /// </summary>
        [XmlElement("locale")]
        public string Locale { get; set; }

        /// <summary>
        /// 隐私数据加密证书链
        /// </summary>
        [XmlArray("private_encryption_cert_chain")]
        [XmlArrayItem("string")]
        public List<string> PrivateEncryptionCertChain { get; set; }

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

        /// <summary>
        /// 卡的x-pod
        /// </summary>
        [XmlElement("x_pod")]
        public string XPod { get; set; }
    }
}
