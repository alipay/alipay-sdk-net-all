using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SignContentBodyResponse Data Structure.
    /// </summary>
    [Serializable]
    public class SignContentBodyResponse : AopObject
    {
        /// <summary>
        /// 钱包客户端签名rsa内容
        /// </summary>
        [XmlElement("alipayapp_rsa_content")]
        public string AlipayappRsaContent { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// h5签名rsa内容
        /// </summary>
        [XmlElement("innerapp_rsa_content")]
        public string InnerappRsaContent { get; set; }
    }
}
