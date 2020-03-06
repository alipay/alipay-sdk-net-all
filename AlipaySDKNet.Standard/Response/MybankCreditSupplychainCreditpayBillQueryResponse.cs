using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSupplychainCreditpayBillQueryResponse.
    /// </summary>
    public class MybankCreditSupplychainCreditpayBillQueryResponse : AopResponse
    {
        /// <summary>
        /// 余额总金额
        /// </summary>
        [XmlElement("balance_amt")]
        public string BalanceAmt { get; set; }

        /// <summary>
        /// 余额罚息金额
        /// </summary>
        [XmlElement("balance_int_amt")]
        public string BalanceIntAmt { get; set; }

        /// <summary>
        /// 余额本金金额
        /// </summary>
        [XmlElement("balance_prin_amt")]
        public string BalancePrinAmt { get; set; }

        /// <summary>
        /// 入账金额
        /// </summary>
        [XmlElement("bill_amt")]
        public string BillAmt { get; set; }

        /// <summary>
        /// 出账日期
        /// </summary>
        [XmlElement("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// 账单罚息金额
        /// </summary>
        [XmlElement("bill_int_amt")]
        public string BillIntAmt { get; set; }

        /// <summary>
        /// 账单本金金额
        /// </summary>
        [XmlElement("bill_prin_amt")]
        public string BillPrinAmt { get; set; }

        /// <summary>
        /// 买方信息，这里是ISV的信息
        /// </summary>
        [XmlElement("buyer")]
        public Member Buyer { get; set; }

        /// <summary>
        /// 1688买家ID
        /// </summary>
        [XmlElement("buyer_scene_id")]
        public string BuyerSceneId { get; set; }

        /// <summary>
        /// 账单状态：NOR/CLR/OVD
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 网商日志ID
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
