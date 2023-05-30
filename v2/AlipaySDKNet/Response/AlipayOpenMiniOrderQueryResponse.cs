using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniOrderQueryResponse.
    /// </summary>
    public class AlipayOpenMiniOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 收货地址
        /// </summary>
        [XmlElement("address_info")]
        public AddressInfoVO AddressInfo { get; set; }

        /// <summary>
        /// 本地生活商品的联系人信息
        /// </summary>
        [XmlElement("contact_info")]
        public ContactInfoVO ContactInfo { get; set; }

        /// <summary>
        /// 创建时间，yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 默认退货地址
        /// </summary>
        [XmlElement("default_receiving_address")]
        public AddressInfoVO DefaultReceivingAddress { get; set; }

        /// <summary>
        /// 配送信息
        /// </summary>
        [XmlElement("delivery_detail")]
        public DeliveryDetailInfoVO DeliveryDetail { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        [XmlElement("merchant_biz_type")]
        public string MerchantBizType { get; set; }

        /// <summary>
        /// 用户openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单详细数据
        /// </summary>
        [XmlElement("order_detail")]
        public OrderDetailInfoVO OrderDetail { get; set; }

        /// <summary>
        /// 商家自定义订单ID(字符仅支持下划线字母数字，长度小于128个字符）
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 订单详情页路径
        /// </summary>
        [XmlElement("path")]
        public string Path { get; set; }

        /// <summary>
        /// 确认收货时间，秒级时间戳，fund_type = 1且确认收货之后存在
        /// </summary>
        [XmlElement("receive_time")]
        public string ReceiveTime { get; set; }

        /// <summary>
        /// 退款信息
        /// </summary>
        [XmlElement("refund_info")]
        public RefundInfoVO RefundInfo { get; set; }

        /// <summary>
        /// normal：即时到账  extended：账期结算
        /// </summary>
        [XmlElement("settle_type")]
        public string SettleType { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 支付单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
