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
        /// 企业签约企业合花ID-共同账号ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 变更模式 ADD - 增加额度 DEDUCT - 扣减额度 UPDATE_BALANCE-更新可用余额 ENABLE-额度启用 DISABLE-额度停用
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 变更的额度（分） 最大值：10000000
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 外部幂等ID
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
    }
}
