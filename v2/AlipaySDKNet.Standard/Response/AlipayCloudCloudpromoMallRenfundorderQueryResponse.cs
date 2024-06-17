using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoMallRenfundorderQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoMallRenfundorderQueryResponse : AopResponse
    {
        /// <summary>
        /// 订单退货方式
        /// </summary>
        [XmlElement("biz_claim_type")]
        public string BizClaimType { get; set; }

        /// <summary>
        /// 逆向创建时间
        /// </summary>
        [XmlElement("dispute_create_time")]
        public string DisputeCreateTime { get; set; }

        /// <summary>
        /// 逆向结束时间
        /// </summary>
        [XmlElement("dispute_end_time")]
        public string DisputeEndTime { get; set; }

        /// <summary>
        /// 逆向的状态
        /// </summary>
        [XmlElement("dispute_status")]
        public string DisputeStatus { get; set; }

        /// <summary>
        /// 主单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 子单id
        /// </summary>
        [XmlElement("order_line_id")]
        public string OrderLineId { get; set; }

        /// <summary>
        /// 退款金额(单位：分)
        /// </summary>
        [XmlElement("refund_fee")]
        public long RefundFee { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 商家退货地址
        /// </summary>
        [XmlElement("refunder_address")]
        public string RefunderAddress { get; set; }

        /// <summary>
        /// refunderName
        /// </summary>
        [XmlElement("refunder_name")]
        public string RefunderName { get; set; }

        /// <summary>
        /// 退货联系方式
        /// </summary>
        [XmlElement("refunder_tel")]
        public string RefunderTel { get; set; }

        /// <summary>
        /// 商家拒绝原因
        /// </summary>
        [XmlElement("seller_refuse_reason")]
        public string SellerRefuseReason { get; set; }
    }
}
