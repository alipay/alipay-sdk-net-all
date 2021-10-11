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
        /// 企业签约企业合花ID-共同账号ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 开票规则id
        /// </summary>
        [XmlElement("invoice_rule_id")]
        public string InvoiceRuleId { get; set; }

        /// <summary>
        /// 支付制度id列表
        /// </summary>
        [XmlArray("standard_id_list")]
        [XmlArrayItem("string")]
        public List<string> StandardIdList { get; set; }
    }
}
