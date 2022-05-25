using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FundSettleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FundSettleInfo : AopObject
    {
        /// <summary>
        /// 银行卡id
        /// </summary>
        [XmlElement("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 计算方式
        /// </summary>
        [XmlElement("cacl_type")]
        public string CaclType { get; set; }

        /// <summary>
        /// 结算方式
        /// </summary>
        [XmlElement("clearing_model")]
        public string ClearingModel { get; set; }

        /// <summary>
        /// 三方银行：THIRD_BANK 网商：ANTBANK
        /// </summary>
        [XmlElement("fund_type")]
        public string FundType { get; set; }

        /// <summary>
        /// 三方银行：third_bank 网商：mybank
        /// </summary>
        [XmlElement("sign_principal")]
        public string SignPrincipal { get; set; }
    }
}
