using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAuthAppAesGetResponse.
    /// </summary>
    public class AlipayOpenAuthAppAesGetResponse : AopResponse
    {
        /// <summary>
        /// 商家应用AES KEY密文，需要ISV使用三方应用配置的AES密钥内容进行解密。通过SDK解密获取明文可参考接口说明中的文档操作。
        /// </summary>
        [XmlElement("aes_key")]
        public string AesKey { get; set; }
    }
}
