using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PrincipalPartyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PrincipalPartyInfo : AopObject
    {
        /// <summary>
        /// 授权主体的支付宝登录号，如传递，则授权用户的登录号必须和指定的登录号匹配，否则授权流程会被阻塞
        /// </summary>
        [XmlElement("principal_account_no")]
        public string PrincipalAccountNo { get; set; }

        /// <summary>
        /// 授权主体证件号，默认为身份证号码
        /// </summary>
        [XmlElement("principal_cert_no")]
        public string PrincipalCertNo { get; set; }

        /// <summary>
        /// 授权主体名称
        /// </summary>
        [XmlElement("principal_name")]
        public string PrincipalName { get; set; }
    }
}
