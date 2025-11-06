using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DidMethodInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DidMethodInfo : AopObject
    {
        /// <summary>
        /// 签名来源
        /// </summary>
        [XmlElement("sign_src")]
        public string SignSrc { get; set; }

        /// <summary>
        /// vm签名值，用于验证数据的完整性
        /// </summary>
        [XmlElement("signature")]
        public string Signature { get; set; }

        /// <summary>
        /// 用户公钥结构
        /// </summary>
        [XmlElement("vm")]
        public string Vm { get; set; }
    }
}
