using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdSecdeviceCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdSecdeviceCertifyModel : AopObject
    {
        /// <summary>
        /// 初始化令牌
        /// </summary>
        [XmlElement("ifaa_token")]
        public string IfaaToken { get; set; }

        /// <summary>
        /// 协议版本
        /// </summary>
        [XmlElement("ifaa_version")]
        public string IfaaVersion { get; set; }

        /// <summary>
        /// 验证数据
        /// </summary>
        [XmlElement("ifaf_message")]
        public string IfafMessage { get; set; }
    }
}
