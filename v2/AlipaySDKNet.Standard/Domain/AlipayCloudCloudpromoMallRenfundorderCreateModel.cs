using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoMallRenfundorderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoMallRenfundorderCreateModel : AopObject
    {
        /// <summary>
        /// 退款类型，不传值则默认选择仅退款
        /// </summary>
        [XmlElement("biz_claim_type")]
        public string BizClaimType { get; set; }

        /// <summary>
        /// 发货状态，不传默认选择未发货状态
        /// </summary>
        [XmlElement("goods_status")]
        public string GoodsStatus { get; set; }

        /// <summary>
        /// 分销子订单id，小程序云分销子订单唯一键值
        /// </summary>
        [XmlElement("order_line_id")]
        public string OrderLineId { get; set; }

        /// <summary>
        /// 退款原因ID，作为退款原因映射，通过渲染售后单获取
        /// </summary>
        [XmlElement("reason_text_id")]
        public string ReasonTextId { get; set; }

        /// <summary>
        /// 退货数量。单位：个
        /// </summary>
        [XmlElement("refund_count")]
        public long RefundCount { get; set; }

        /// <summary>
        /// 退款金额（单位：分）
        /// </summary>
        [XmlElement("refund_fee")]
        public long RefundFee { get; set; }
    }
}
