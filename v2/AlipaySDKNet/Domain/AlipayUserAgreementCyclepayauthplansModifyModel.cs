using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAgreementCyclepayauthplansModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAgreementCyclepayauthplansModifyModel : AopObject
    {
        /// <summary>
        /// 代扣协议协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 单笔支付金额，单位是元
        /// </summary>
        [XmlElement("single_amount")]
        public string SingleAmount { get; set; }

        /// <summary>
        /// 总扣款期数，入参为自然数，代表期数值。
        /// </summary>
        [XmlElement("total_payments")]
        public string TotalPayments { get; set; }
    }
}
