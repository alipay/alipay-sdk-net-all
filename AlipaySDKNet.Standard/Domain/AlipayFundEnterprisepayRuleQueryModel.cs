using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundEnterprisepayRuleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundEnterprisepayRuleQueryModel : AopObject
    {
        /// <summary>
        /// 企业签约账户ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 平台和企业的三方授权协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 场景码，联系支付宝分配
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 用户ID，当操作类型=MEMBER 时必填
        /// </summary>
        [XmlElement("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 操作类型： ACCOUNT-账户 MEMBER-成员
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 产品码，默认值 ENTERPRISE_PAY
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 查询类型： QUOTA - 额度 TRADE - 商户限制 可都查询，也可以只查一个
        /// </summary>
        [XmlArray("rule_type")]
        [XmlArrayItem("string")]
        public List<string> RuleType { get; set; }
    }
}
