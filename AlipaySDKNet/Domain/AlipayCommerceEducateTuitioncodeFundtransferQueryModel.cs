using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateTuitioncodeFundtransferQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateTuitioncodeFundtransferQueryModel : AopObject
    {
        /// <summary>
        /// 订单付款人的支付宝用户编号
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 资金划拨操作类型：DISBURSE - 打款；REFUND - 退款
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 外部商户的订单编号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 资金划拨的外部请求编号，对应服务商申请打款或申请退款请求的request_id
        /// </summary>
        [XmlElement("out_req_no")]
        public string OutReqNo { get; set; }

        /// <summary>
        /// 直付通二级商户的支付宝编号
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 订单付款人的支付宝用户编号
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
