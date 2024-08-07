using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcEnterpriseAgreementQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcEnterpriseAgreementQueryModel : AopObject
    {
        /// <summary>
        /// 资金共同账号id；enterprise_id与account_id至少传一个，如果都传了优先使用enterprise_id 当前字段已废弃(为兼容企业码1.0老接口保留的字段，已过时，新接客户请使用enterprise_id)
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 企业id；enterprise_id与account_id至少传一个，如果都传了优先使用enterprise_id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }
    }
}
