using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoantradeBillBudgetQueryResponse.
    /// </summary>
    public class MybankCreditLoantradeBillBudgetQueryResponse : AopResponse
    {
        /// <summary>
        /// 预算明细
        /// </summary>
        [XmlElement("bill_repay_budget")]
        public BillRepayBudgetVO BillRepayBudget { get; set; }

        /// <summary>
        /// 不可见不可用信息
        /// </summary>
        [XmlElement("refuse_msg")]
        public RefuseVo RefuseMsg { get; set; }

        /// <summary>
        /// 标识本次请求是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
