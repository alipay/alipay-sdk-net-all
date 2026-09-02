using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// XingheLendassistCarfinauctionApplystatusQueryResponse.
    /// </summary>
    public class XingheLendassistCarfinauctionApplystatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 星河申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 贷款银行联系电话
        /// </summary>
        [XmlElement("bank_account_manager_contract_number")]
        public string BankAccountManagerContractNumber { get; set; }

        /// <summary>
        /// 放款时间
        /// </summary>
        [XmlElement("disburse_time")]
        public string DisburseTime { get; set; }

        /// <summary>
        /// 面签金额，单位元
        /// </summary>
        [XmlElement("loan_amount")]
        public string LoanAmount { get; set; }

        /// <summary>
        /// 外部订单号（阿里拍卖申请单号）
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 申请状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
