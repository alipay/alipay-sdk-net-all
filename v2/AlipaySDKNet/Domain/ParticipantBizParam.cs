using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ParticipantBizParam Data Structure.
    /// </summary>
    [Serializable]
    public class ParticipantBizParam : AopObject
    {
        /// <summary>
        /// 代发专户ID
        /// </summary>
        [XmlElement("account_book_id")]
        public string AccountBookId { get; set; }

        /// <summary>
        /// 协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 出资比例
        /// </summary>
        [XmlElement("fund_ratio")]
        public string FundRatio { get; set; }

        /// <summary>
        /// 出资类型
        /// </summary>
        [XmlElement("fund_type")]
        public string FundType { get; set; }

        /// <summary>
        /// 间连商户ID
        /// </summary>
        [XmlElement("sub_merchant_id")]
        public string SubMerchantId { get; set; }

        /// <summary>
        /// 间连商户类型
        /// </summary>
        [XmlElement("sub_merchant_id_type")]
        public string SubMerchantIdType { get; set; }
    }
}
