using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasDigitalcredentialVpQueryResponse.
    /// </summary>
    public class DatadigitalFincloudGeneralsaasDigitalcredentialVpQueryResponse : AopResponse
    {
        /// <summary>
        /// 加密后的VP数据。
        /// </summary>
        [XmlElement("cipher")]
        public string Cipher { get; set; }

        /// <summary>
        /// 客户用于定位解密私钥的密钥别名。
        /// </summary>
        [XmlElement("key_alias")]
        public string KeyAlias { get; set; }

        /// <summary>
        /// 加密后的对称密钥。
        /// </summary>
        [XmlElement("key_cipher")]
        public string KeyCipher { get; set; }
    }
}
