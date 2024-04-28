using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FundRuleModelDTO Data Structure.
    /// </summary>
    [Serializable]
    public class FundRuleModelDTO : AopObject
    {
        /// <summary>
        /// 出资协议号，由出资协议创建时获取
        /// </summary>
        [XmlElement("fund_agreement_no")]
        public string FundAgreementNo { get; set; }

        /// <summary>
        /// 出资金额
        /// </summary>
        [XmlElement("fund_amount")]
        public string FundAmount { get; set; }

        /// <summary>
        /// 商户减收类型，后续商户发起支付时，会优先校验支付发起的商户是否存在对应的有效协议，如果不存在，则支付中无法使用对应的商链通优惠；该字段与fund_agreement_no二选一即可，如果传入了fund_agreement_no，则优先使用fund_agreement_no。
        /// </summary>
        [XmlElement("fund_type")]
        public string FundType { get; set; }
    }
}
