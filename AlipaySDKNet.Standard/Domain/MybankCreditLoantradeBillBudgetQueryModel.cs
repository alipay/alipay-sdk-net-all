using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoantradeBillBudgetQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoantradeBillBudgetQueryModel : AopObject
    {
        /// <summary>
        /// 申请金额
        /// </summary>
        [XmlElement("apply_amount")]
        public MultiCurrencyMoney ApplyAmount { get; set; }

        /// <summary>
        /// 账单编号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 外部统一编码，类似2018041701025002005 027088555
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 预算类型(本金试算PRIN_BUDGET或总额试算TOTAL_BUDGET)
        /// </summary>
        [XmlElement("repay_budget_type")]
        public string RepayBudgetType { get; set; }

        /// <summary>
        /// 用户的基本信息，包括支付宝id，site,steUserId等
        /// </summary>
        [XmlElement("user")]
        public UserVo User { get; set; }
    }
}
