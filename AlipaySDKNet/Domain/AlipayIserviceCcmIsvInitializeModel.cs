using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmIsvInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmIsvInitializeModel : AopObject
    {
        /// <summary>
        /// 用于接入ccm iframe接口安全认证的isv公钥，采用base64编码，秘钥对生成算法:RSA2048
        /// </summary>
        [XmlElement("isv_pub_key")]
        public string IsvPubKey { get; set; }
    }
}
