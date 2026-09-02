using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtHrcominsuOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtHrcominsuOrderSyncModel : AopObject
    {
        /// <summary>
        /// 支付宝UID
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 渠道订单号（闪购侧订单号）
        /// </summary>
        [XmlElement("channel_order_no")]
        public string ChannelOrderNo { get; set; }

        /// <summary>
        /// 渠道原始状态，保留用于追溯。
        /// </summary>
        [XmlElement("channel_raw_status")]
        public string ChannelRawStatus { get; set; }

        /// <summary>
        /// 家空间统一订单状态，用于查询和状态机驱动。支付宝商家渠道由系统根据channel_raw_status自动映射；闪购渠道由调用方直接传入
        /// </summary>
        [XmlElement("channel_status")]
        public string ChannelStatus { get; set; }

        /// <summary>
        /// 渠道类型，支付宝商家传 ALIPAY_MERCHANT、淘宝闪购传 TAOBAO_FLASH_SALE、企业码传 ENTERPRISE_CODE、自营传 SELF_OPERATED
        /// </summary>
        [XmlElement("channel_type")]
        public string ChannelType { get; set; }

        /// <summary>
        /// 客户租户 家空间的客户例如 ：蚂蚁、数马
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 外部订单详情跳转URL（静态）
        /// </summary>
        [XmlElement("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("order_item_d_t_o")]
        public List<OrderItemDTO> Items { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 商家编号
        /// </summary>
        [XmlElement("merchant_no")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 下单时手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 支付宝下的应用ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单创建时间 13位时间戳
        /// </summary>
        [XmlElement("order_time")]
        public string OrderTime { get; set; }

        /// <summary>
        /// 实付款金额（单位：元，必须为两位小数点的正数，如 99.90）
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }
    }
}
