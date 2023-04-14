using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCreditCreditriskDashboardQueryResponse.
    /// </summary>
    public class AlipayCreditCreditriskDashboardQueryResponse : AopResponse
    {
        /// <summary>
        /// 信用贷款额度
        /// </summary>
        [XmlElement("credit_loan")]
        public string CreditLoan { get; set; }

        /// <summary>
        /// 售后退款金额
        /// </summary>
        [XmlElement("sale_refund")]
        public string SaleRefund { get; set; }

        /// <summary>
        /// 交易服务费
        /// </summary>
        [XmlElement("service_charge")]
        public string ServiceCharge { get; set; }

        /// <summary>
        /// 收入总计
        /// </summary>
        [XmlElement("total_income")]
        public string TotalIncome { get; set; }

        /// <summary>
        /// 支出总计
        /// </summary>
        [XmlElement("total_payout")]
        public string TotalPayout { get; set; }

        /// <summary>
        /// 提前收款额度
        /// </summary>
        [XmlElement("tqsk_loan")]
        public string TqskLoan { get; set; }

        /// <summary>
        /// 余利宝收益
        /// </summary>
        [XmlElement("ylb_profit")]
        public string YlbProfit { get; set; }
    }
}
