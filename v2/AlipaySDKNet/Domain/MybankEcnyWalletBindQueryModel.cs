using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankEcnyWalletBindQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankEcnyWalletBindQueryModel : AopObject
    {
        /// <summary>
        /// 绑定场景
        /// </summary>
        [XmlElement("bind_scene")]
        public string BindScene { get; set; }

        /// <summary>
        /// 用户证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 用户在平台的角色
        /// </summary>
        [XmlElement("role_type")]
        public string RoleType { get; set; }
    }
}
