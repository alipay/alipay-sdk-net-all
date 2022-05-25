using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoantradeGuarletterBidwinNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoantradeGuarletterBidwinNotifyModel : AopObject
    {
        /// <summary>
        /// 标的明细
        /// </summary>
        [XmlElement("bid_detail")]
        public BidDetailVO BidDetail { get; set; }

        /// <summary>
        /// 方案合约号
        /// </summary>
        [XmlElement("scheme_ar_no")]
        public string SchemeArNo { get; set; }

        /// <summary>
        /// 中标人信息
        /// </summary>
        [XmlElement("winer_user_info")]
        public EnterpriseCustomerInfoVO WinerUserInfo { get; set; }
    }
}
