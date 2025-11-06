using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCustomerZmcardCarownerQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerZmcardCarownerQueryModel : AopObject
    {
        /// <summary>
        /// 真实姓名
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 用户身份号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 名片角色类型
        /// </summary>
        [XmlElement("role_type")]
        public string RoleType { get; set; }

        /// <summary>
        /// 来源：小程序/端外APP
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
