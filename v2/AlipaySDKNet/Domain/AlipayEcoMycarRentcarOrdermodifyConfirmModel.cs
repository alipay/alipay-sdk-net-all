using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarRentcarOrdermodifyConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarRentcarOrdermodifyConfirmModel : AopObject
    {
        /// <summary>
        /// 若拒绝修改，则车生活会取消修改订单并给用户退款
        /// </summary>
        [XmlElement("confirm_result")]
        public string ConfirmResult { get; set; }

        /// <summary>
        /// 修改单的商户侧订单号
        /// </summary>
        [XmlElement("modified_out_order_no")]
        public string ModifiedOutOrderNo { get; set; }

        /// <summary>
        /// 支付宝用户开放id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 发起修改订单的租车单的商户侧订单号
        /// </summary>
        [XmlElement("parent_out_order_no")]
        public string ParentOutOrderNo { get; set; }

        /// <summary>
        /// 用于向用户展示修改订单失败的原因，当confirm_result为REJECT时必传
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }

        /// <summary>
        /// 支付宝用户的userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
