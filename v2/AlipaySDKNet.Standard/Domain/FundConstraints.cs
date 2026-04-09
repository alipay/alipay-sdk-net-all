using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FundConstraints Data Structure.
    /// </summary>
    [Serializable]
    public class FundConstraints : AopObject
    {
        /// <summary>
        /// 企业在企业码平台开通的出资账户标识
        /// </summary>
        [XmlElement("deduct_account_id")]
        public string DeductAccountId { get; set; }

        /// <summary>
        /// 服务商在企业码平台发布的服务标识
        /// </summary>
        [XmlElement("fund_service_id")]
        public string FundServiceId { get; set; }

        /// <summary>
        /// 限定出资的银行卡号
        /// </summary>
        [XmlElement("specified_bank_card_no")]
        public string SpecifiedBankCardNo { get; set; }
    }
}
