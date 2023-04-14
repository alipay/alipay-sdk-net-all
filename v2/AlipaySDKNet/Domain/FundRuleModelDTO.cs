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
    }
}
