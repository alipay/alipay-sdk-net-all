using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayCodecApplepayBarcodeeventNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayCodecApplepayBarcodeeventNotifyModel : AopObject
    {
        /// <summary>
        /// 码的id。{Identifier for this credential}
        /// </summary>
        [XmlElement("barcode_identifier")]
        public string BarcodeIdentifier { get; set; }

        /// <summary>
        /// 上报事件，Base64 encoded UTF-8 bytes of Event Data JSON object defined below.
        /// </summary>
        [XmlElement("event")]
        public string Event { get; set; }

        /// <summary>
        /// 上报时间的签名，Base64 encoded PKCS#7 detached ECDSA signature. Signature data is generated over the SHA- 256 hash of Base64 decoded event bytes。
        /// </summary>
        [XmlElement("signature")]
        public string Signature { get; set; }
    }
}
