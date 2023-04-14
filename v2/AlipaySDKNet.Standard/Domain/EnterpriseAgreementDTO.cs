using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EnterpriseAgreementDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EnterpriseAgreementDTO : AopObject
    {
        /// <summary>
        /// 协议id
        /// </summary>
        [XmlElement("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("enterprise_name")]
        public string EnterpriseName { get; set; }

        /// <summary>
        /// 签约时间
        /// </summary>
        [XmlElement("sign_date")]
        public string SignDate { get; set; }

        /// <summary>
        /// 签约状态（UNSIGNED：未签约，SIGNED：已签约，TERMINATED：已解约）
        /// </summary>
        [XmlElement("sign_status")]
        public string SignStatus { get; set; }
    }
}
