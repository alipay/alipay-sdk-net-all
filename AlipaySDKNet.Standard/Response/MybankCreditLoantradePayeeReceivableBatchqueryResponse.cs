using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoantradePayeeReceivableBatchqueryResponse.
    /// </summary>
    public class MybankCreditLoantradePayeeReceivableBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 应收列表
        /// </summary>
        [XmlArray("receivable_list")]
        [XmlArrayItem("credit_pay_receivable_v_o")]
        public List<CreditPayReceivableVO> ReceivableList { get; set; }

        /// <summary>
        /// 总计应收金额
        /// </summary>
        [XmlElement("total_rcv_amt")]
        public CreditPayMoneyVO TotalRcvAmt { get; set; }
    }
}
