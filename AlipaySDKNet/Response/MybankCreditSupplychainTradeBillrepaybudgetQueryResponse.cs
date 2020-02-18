using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSupplychainTradeBillrepaybudgetQueryResponse.
    /// </summary>
    public class MybankCreditSupplychainTradeBillrepaybudgetQueryResponse : AopResponse
    {
        /// <summary>
        /// 账单金额明细
        /// </summary>
        [XmlElement("bill_amt_detail")]
        public CustScpBillAmtVO BillAmtDetail { get; set; }

        /// <summary>
        /// 是否可以还款
        /// </summary>
        [XmlElement("can_repay")]
        public bool CanRepay { get; set; }

        /// <summary>
        /// exempt_amt:减免金额
        /// </summary>
        [XmlElement("exempt_amt")]
        public string ExemptAmt { get; set; }

        /// <summary>
        /// 分期明细
        /// </summary>
        [XmlArray("install_budget_detail_list")]
        [XmlArrayItem("cust_scp_installment_budget_v_o")]
        public List<CustScpInstallmentBudgetVO> InstallBudgetDetailList { get; set; }

        /// <summary>
        /// 外部账款编号
        /// </summary>
        [XmlElement("out_order")]
        public string OutOrder { get; set; }

        /// <summary>
        /// 账单状态：WAIT_RECEIPT:待供应商收款,RECEIPTED:供应商已收款,CLEAR:已结清,OVERDUE:逾期 ,INVALID:失效 ,CANCEL:取消
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 账单总金额
        /// </summary>
        [XmlElement("total_amt")]
        public string TotalAmt { get; set; }
    }
}
