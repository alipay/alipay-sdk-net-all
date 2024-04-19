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
        /// 用于接入CCM iframe接口安全认证的 ISV 公钥，采用 base64 编码，秘钥对生成算法为 RSA2048。
        /// </summary>
        [XmlElement("isv_pub_key")]
        public string IsvPubKey { get; set; }
    }
}
