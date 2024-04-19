using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceExpensecontrolQuotaModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceExpensecontrolQuotaModifyModel : AopObject
    {
        /// <summary>
        /// 企业共同账户ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 变更模式
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 变更的金额/余额，以（分）为单位，当变更的资产类型为次卡时，当前的单位为次
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 外部操作幂等ID（接入方接口调用幂等控制ID）
        /// </summary>
        [XmlElement("outer_source_id")]
        public string OuterSourceId { get; set; }

        /// <summary>
        /// 外部平台编码
        /// </summary>
        [XmlElement("platform")]
        public string Platform { get; set; }

        /// <summary>
        /// 额度ID
        /// </summary>
        [XmlElement("quota_id")]
        public string QuotaId { get; set; }

        /// <summary>
        /// 是否可转赠，1表示可转赠，0表示不可转赠
        /// </summary>
        [XmlElement("share_mode")]
        public string ShareMode { get; set; }
    }
}
