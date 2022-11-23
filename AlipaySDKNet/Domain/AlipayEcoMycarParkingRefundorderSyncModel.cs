using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingRefundorderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingRefundorderSyncModel : AopObject
    {
        /// <summary>
        /// 订单对应的车牌号
        /// </summary>
        [XmlElement("car_number")]
        public string CarNumber { get; set; }

        /// <summary>
        /// 应用维度用户ID，唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝支付流水trade_no，系统唯一
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部退款单号，由外部生成在发起退款时作为输入参数的字段
        /// </summary>
        [XmlElement("out_refund_no")]
        public string OutRefundNo { get; set; }

        /// <summary>
        /// 退款金额，保留小数点后两位
        /// </summary>
        [XmlElement("refund_money")]
        public string RefundMoney { get; set; }

        /// <summary>
        /// 退款时间, 格式"YYYYMM-DD HH:mm:ss"，24小时制
        /// </summary>
        [XmlElement("refund_time")]
        public string RefundTime { get; set; }

        /// <summary>
        /// 停车缴费用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 注意：ISV需保证用户 id的正确性，以免导致用户在停车平台查询不到相关的订单信息。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
