using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcConsumeDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcConsumeDetailQueryModel : AopObject
    {
        /// <summary>
        /// 共同账户ID 当前字段已废弃(该字段将废弃，不建议使用，可用enterprise_id字段替换)
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号 当前字段已废弃(该字段将废弃，不建议使用，可用enterprise_id字段替换)
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 支付宝账单号
        /// </summary>
        [XmlElement("pay_no")]
        public string PayNo { get; set; }

        /// <summary>
        /// 查询选项
        /// </summary>
        [XmlArray("query_options")]
        [XmlArrayItem("string")]
        public List<string> QueryOptions { get; set; }
    }
}
