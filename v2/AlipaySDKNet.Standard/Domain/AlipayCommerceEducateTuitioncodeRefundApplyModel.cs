using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateTuitioncodeRefundApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateTuitioncodeRefundApplyModel : AopObject
    {
        /// <summary>
        /// 订单支付人支付宝编号
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部商户的订单编号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 退已打款计划明细： 当退款类型为2时必填
        /// </summary>
        [XmlArray("refund_paid_detail_list")]
        [XmlArrayItem("refund_paid_detail")]
        public List<RefundPaidDetail> RefundPaidDetailList { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 退款类型： 1-退未打款 2-退已打款 3-全部
        /// </summary>
        [XmlElement("refund_type")]
        public long RefundType { get; set; }

        /// <summary>
        /// 部分退款时：外部幂等号，长度不能超过32位
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 二级商户
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 订单支付人支付宝编号
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
