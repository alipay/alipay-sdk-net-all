using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdIifaaDidTriggerModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdIifaaDidTriggerModel : AopObject
    {
        /// <summary>
        /// 操作类型
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// IIFAA did别名
        /// </summary>
        [XmlElement("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// IIFAA设备唯一标识
        /// </summary>
        [XmlElement("did")]
        public string Did { get; set; }

        /// <summary>
        /// 用户公钥结构
        /// </summary>
        [XmlArray("methods")]
        [XmlArrayItem("string")]
        public List<string> Methods { get; set; }

        /// <summary>
        /// did协议版本号
        /// </summary>
        [XmlElement("pro_version")]
        public string ProVersion { get; set; }

        /// <summary>
        /// 用户自签名信息，需要验证用户身份时传入
        /// </summary>
        [XmlArray("self_sign_info")]
        [XmlArrayItem("self_sign_info")]
        public List<SelfSignInfo> SelfSignInfo { get; set; }

        /// <summary>
        /// did文档和签名值
        /// </summary>
        [XmlElement("sign_document")]
        public string SignDocument { get; set; }

        /// <summary>
        /// []
        /// </summary>
        [XmlArray("sign_methods")]
        [XmlArrayItem("did_method_info")]
        public List<DidMethodInfo> SignMethods { get; set; }
    }
}
