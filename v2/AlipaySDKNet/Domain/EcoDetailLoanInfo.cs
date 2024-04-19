using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcoDetailLoanInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EcoDetailLoanInfo : AopObject
    {
        /// <summary>
        /// 借款额度，单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("loan_amount")]
        public string LoanAmount { get; set; }

        /// <summary>
        /// 借款事由
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 转账单号
        /// </summary>
        [XmlElement("trans_no")]
        public string TransNo { get; set; }

        /// <summary>
        /// 转账方式
        /// </summary>
        [XmlElement("trans_type")]
        public string TransType { get; set; }
    }
}
