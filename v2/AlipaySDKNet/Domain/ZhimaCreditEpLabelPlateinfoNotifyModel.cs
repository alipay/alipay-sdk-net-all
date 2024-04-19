using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpLabelPlateinfoNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpLabelPlateinfoNotifyModel : AopObject
    {
        /// <summary>
        /// 下单渠道-触发推送的下单渠道-印鸽订单-商户传入
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 订单佣金-触发推送的订单佣金-印鸽订单-商户传入
        /// </summary>
        [XmlElement("commission")]
        public long Commission { get; set; }

        /// <summary>
        /// 订单创建时间时间戳-触发推送的订单创建时间时间戳-印鸽订单-商户传入
        /// </summary>
        [XmlElement("created_at")]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 订单支付时间-触发推送的订单订单支付时间-印鸽订单-商户传入
        /// </summary>
        [XmlElement("delivered_at")]
        public string DeliveredAt { get; set; }

        /// <summary>
        /// 最近签收时间-触发推送的最近签收时间-印鸽订单-商户传入
        /// </summary>
        [XmlElement("delivered_signed_at")]
        public string DeliveredSignedAt { get; set; }

        /// <summary>
        /// 佣金发放时间-触发推送的佣金发放时间-印鸽订单-商户传入
        /// </summary>
        [XmlElement("granted_at")]
        public string GrantedAt { get; set; }

        /// <summary>
        /// 外部业务号 outUserId
        /// </summary>
        [XmlElement("inner_biz_no")]
        public string InnerBizNo { get; set; }

        /// <summary>
        /// 扩展信息-触发推送的扩展信息-印鸽订单-商户传入
        /// </summary>
        [XmlElement("order_extends")]
        public string OrderExtends { get; set; }

        /// <summary>
        /// 订单实付金额-触发推送的订单实付金额-印鸽订单-商户传入-单位（分）
        /// </summary>
        [XmlElement("pay_amount")]
        public long PayAmount { get; set; }

        /// <summary>
        /// 订单支付时间-触发推送的订单订单支付时间-印鸽订单-商户传入
        /// </summary>
        [XmlElement("pay_at")]
        public string PayAt { get; set; }

        /// <summary>
        /// 邮费金额-触发推送的邮费金额-印鸽订单-商户传入 单位（分）
        /// </summary>
        [XmlElement("postage_amount")]
        public long PostageAmount { get; set; }

        /// <summary>
        /// 商品金额-触发推送的商品金额-印鸽订单-商户传入 单位（分）
        /// </summary>
        [XmlElement("product_amount")]
        public long ProductAmount { get; set; }

        /// <summary>
        /// 退款金额-触发推送的退款金额-印鸽订单-商户传入 单位（分）
        /// </summary>
        [XmlElement("refund_amount")]
        public long RefundAmount { get; set; }

        /// <summary>
        /// 最近退款时间-触发推送的最近退款时间-印鸽订单-商户传入
        /// </summary>
        [XmlElement("refund_at")]
        public string RefundAt { get; set; }

        /// <summary>
        /// 订单状态-触发推送的订单状态-印鸽订单-商户传入
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 节点标识-触发推送的节点标识-印鸽订单-商户传入
        /// </summary>
        [XmlElement("trigger_event_flag")]
        public long TriggerEventFlag { get; set; }

        /// <summary>
        /// 外部订单号-触发推送的具体订单号-印鸽订单-商户传入
        /// </summary>
        [XmlElement("trigger_order_sn")]
        public string TriggerOrderSn { get; set; }
    }
}
