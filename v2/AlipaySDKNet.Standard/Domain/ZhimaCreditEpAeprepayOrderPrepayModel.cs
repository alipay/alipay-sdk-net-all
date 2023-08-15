using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpAeprepayOrderPrepayModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpAeprepayOrderPrepayModel : AopObject
    {
        /// <summary>
        /// 扩展预留
        /// </summary>
        [XmlElement("ext_param")]
        public ZmEpAePrepayExtParam ExtParam { get; set; }

        /// <summary>
        /// 是否放款成功
        /// </summary>
        [XmlElement("make_loan_success")]
        public bool MakeLoanSuccess { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        [XmlElement("order_num")]
        public string OrderNum { get; set; }

        /// <summary>
        /// 审核单创建时间戳
        /// </summary>
        [XmlElement("order_time_millis")]
        public string OrderTimeMillis { get; set; }

        /// <summary>
        /// 商家登陆id
        /// </summary>
        [XmlElement("seller_login_id")]
        public string SellerLoginId { get; set; }

        /// <summary>
        /// 子单担保金额。货币最小单位，如人民币：分
        /// </summary>
        [XmlElement("sub_order_amt")]
        public string SubOrderAmt { get; set; }

        /// <summary>
        /// 子单保金额币种
        /// </summary>
        [XmlElement("sub_order_ccy")]
        public string SubOrderCcy { get; set; }

        /// <summary>
        /// 用户担保金额。货币最小单位，如人民币：分
        /// </summary>
        [XmlElement("sub_order_loan_amt")]
        public string SubOrderLoanAmt { get; set; }

        /// <summary>
        /// 用户担保金额币种
        /// </summary>
        [XmlElement("sub_order_loan_ccy")]
        public string SubOrderLoanCcy { get; set; }

        /// <summary>
        /// 子单id
        /// </summary>
        [XmlElement("sub_order_num")]
        public string SubOrderNum { get; set; }
    }
}
