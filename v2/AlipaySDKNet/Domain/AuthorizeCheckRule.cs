using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AuthorizeCheckRule Data Structure.
    /// </summary>
    [Serializable]
    public class AuthorizeCheckRule : AopObject
    {
        /// <summary>
        /// 企业统一信用编号，传值则会校验授权方与被授权方信用编号是否一致
        /// </summary>
        [XmlElement("enterprise_cert_no")]
        public string EnterpriseCertNo { get; set; }

        /// <summary>
        /// 用于限制被授权方账号类型，  CORPORATE_ACCOUNT:企业账户，PRIVATE_ACCOUNT:个人账户，ALL:支持所有账户类型
        /// </summary>
        [XmlElement("partner_user_type_limit")]
        public string PartnerUserTypeLimit { get; set; }

        /// <summary>
        /// 用于限制授权方账号类型，CORPORATE_ACCOUNT-企业，PRIVATE_ACCOUNT-个人，ALL-支持企业和个人
        /// </summary>
        [XmlElement("principal_user_type_limit")]
        public string PrincipalUserTypeLimit { get; set; }
    }
}
