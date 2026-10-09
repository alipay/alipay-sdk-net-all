using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcCreditLoanCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcCreditLoanCancelModel : AopObject
    {
        /// <summary>
        /// 共同账户ID 当前字段已废弃(历史兼容逻辑冗余字段增加了接口复杂性，统一移除)
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号 当前字段已废弃(历史兼容逻辑冗余字段增加了接口复杂性，统一移除)
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 企业Id，企业入驻企业码时自动分配的用于唯一标识的编号
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 外部业务单号，调用方生成的用于唯一标识借款申请的单据号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
