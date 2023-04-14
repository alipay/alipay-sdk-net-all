using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContractUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ContractUserInfo : AopObject
    {
        /// <summary>
        /// 用户身份证号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 用户uid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户签署区配置，userType=USER
        /// </summary>
        [XmlElement("sign_area")]
        public ContractSignArea SignArea { get; set; }

        /// <summary>
        /// 用户uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
