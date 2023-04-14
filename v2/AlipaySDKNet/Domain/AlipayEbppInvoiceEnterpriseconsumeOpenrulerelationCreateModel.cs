using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceEnterpriseconsumeOpenrulerelationCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceEnterpriseconsumeOpenrulerelationCreateModel : AopObject
    {
        /// <summary>
        /// 企业共同账户ID【不推荐使用】
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号（当仅使用account_id时，必传）
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 企业ID【推荐使用】
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 开票规则ID
        /// </summary>
        [XmlElement("invoice_rule_id")]
        public string InvoiceRuleId { get; set; }

        /// <summary>
        /// 费控规则ID列表
        /// </summary>
        [XmlArray("standard_id_list")]
        [XmlArrayItem("string")]
        public List<string> StandardIdList { get; set; }
    }
}
