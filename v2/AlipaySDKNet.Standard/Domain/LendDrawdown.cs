using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LendDrawdown Data Structure.
    /// </summary>
    [Serializable]
    public class LendDrawdown : AopObject
    {
        /// <summary>
        /// 机构侧支用号
        /// </summary>
        [XmlElement("fin_drawdown_no")]
        public string FinDrawdownNo { get; set; }

        /// <summary>
        /// 资方机构名称（全称）
        /// </summary>
        [XmlElement("fin_org")]
        public string FinOrg { get; set; }

        /// <summary>
        /// 资金利率，小数形式
        /// </summary>
        [XmlElement("fund_rate")]
        public string FundRate { get; set; }

        /// <summary>
        /// 客户放款金额，单位分
        /// </summary>
        [XmlElement("loan_amt")]
        public long LoanAmt { get; set; }

        /// <summary>
        /// 客户放款成功日期
        /// </summary>
        [XmlElement("loan_date")]
        public string LoanDate { get; set; }

        /// <summary>
        /// 客户贷款利率(部分机构称“综合利率”)
        /// </summary>
        [XmlElement("loan_rate")]
        public string LoanRate { get; set; }

        /// <summary>
        /// 客户贷款期次
        /// </summary>
        [XmlElement("loan_term")]
        public long LoanTerm { get; set; }

        /// <summary>
        /// 客户贷款期次类型
        /// </summary>
        [XmlElement("loan_term_unit")]
        public string LoanTermUnit { get; set; }

        /// <summary>
        /// 贷款类型
        /// </summary>
        [XmlElement("loan_type")]
        public string LoanType { get; set; }

        /// <summary>
        /// 抵押率，小数形式
        /// </summary>
        [XmlElement("mortgage_rate")]
        public string MortgageRate { get; set; }

        /// <summary>
        /// 机构侧支用号
        /// </summary>
        [XmlElement("org_drawdown_no")]
        public string OrgDrawdownNo { get; set; }

        /// <summary>
        /// 产品编码 一般固定为VMP，如需使用其他编码请详细咨询沟通
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 还款方式
        /// </summary>
        [XmlElement("repay_type")]
        public string RepayType { get; set; }

        /// <summary>
        /// 服务费率（融担费率、保险费率等），小数形式
        /// </summary>
        [XmlElement("service_fee_rate")]
        public string ServiceFeeRate { get; set; }

        /// <summary>
        /// 服务类型信息
        /// </summary>
        [XmlElement("service_info")]
        public CarfinLendServiceInfo ServiceInfo { get; set; }

        /// <summary>
        /// 车辆估值，单位分
        /// </summary>
        [XmlElement("valuate_price")]
        public long ValuatePrice { get; set; }
    }
}
