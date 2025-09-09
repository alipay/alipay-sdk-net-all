using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FsFundInfoForm Data Structure.
    /// </summary>
    [Serializable]
    public class FsFundInfoForm : AopObject
    {
        /// <summary>
        /// 退款时为出资方退款金额，单位：元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 出资主体，信用红包下传递银行机构ID
        /// </summary>
        [XmlElement("fund_principal")]
        public string FundPrincipal { get; set; }

        /// <summary>
        /// 出资方类型：平台出资，商户出资，第三方机构出资
        /// </summary>
        [XmlElement("fund_provider")]
        public string FundProvider { get; set; }

        /// <summary>
        /// 出资类型：余额出资
        /// </summary>
        [XmlElement("fund_type")]
        public string FundType { get; set; }

        /// <summary>
        /// 出资账号对应的uid
        /// </summary>
        [XmlElement("fund_user_id")]
        public string FundUserId { get; set; }

        /// <summary>
        /// 还款银行信息
        /// </summary>
        [XmlElement("repay_bank_info")]
        public RepayBankInfo RepayBankInfo { get; set; }
    }
}
