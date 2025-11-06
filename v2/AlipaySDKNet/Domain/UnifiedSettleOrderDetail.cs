using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UnifiedSettleOrderDetail Data Structure.
    /// </summary>
    [Serializable]
    public class UnifiedSettleOrderDetail : AopObject
    {
        /// <summary>
        /// 订单同步金额，biz_type=PAY_SYNC时为支付金额，biz_type=REFUND_SYNC时为退款金额。以元为单位，人民币。
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 用于标识收结易的业务模式，不传为默认模式
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 实际外部支付渠道支付或退款发生时间
        /// </summary>
        [XmlElement("external_inst_biz_date")]
        public string ExternalInstBizDate { get; set; }

        /// <summary>
        /// 实际外部支付渠道交易创建时间
        /// </summary>
        [XmlElement("external_inst_create_date")]
        public string ExternalInstCreateDate { get; set; }

        /// <summary>
        /// 收结易在支付宝侧实际创建的时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 表示机构打款单号，一个 inst_order_id 对应用户的一次打款。对应同步接口传入的 inst_order_id。
        /// </summary>
        [XmlElement("inst_order_id")]
        public string InstOrderId { get; set; }

        /// <summary>
        /// 收结易的单号，一般与外部商户订单号一一对应，可能对应多个流水请求号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单同步受理时生成的单号，一般与外部商户流水号一一对应，标识唯一一次订单同步请求
        /// </summary>
        [XmlElement("order_sync_id")]
        public string OrderSyncId { get; set; }

        /// <summary>
        /// 请求流水号。由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端单笔交易维度不重复。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户订单号。 由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端不重复。
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 同步流水的类型，支付为PAY_SYNC，退款为REFUND_SYNC
        /// </summary>
        [XmlElement("request_type")]
        public string RequestType { get; set; }

        /// <summary>
        /// 收结易同步订单执行状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
