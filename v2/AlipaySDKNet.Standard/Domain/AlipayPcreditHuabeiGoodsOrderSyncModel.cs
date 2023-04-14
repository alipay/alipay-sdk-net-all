using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiGoodsOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiGoodsOrderSyncModel : AopObject
    {
        /// <summary>
        /// 支付宝订单ID
        /// </summary>
        [XmlElement("alipay_order_id")]
        public string AlipayOrderId { get; set; }

        /// <summary>
        /// 支付宝userId
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 外部商品ID
        /// </summary>
        [XmlElement("biz_item_id")]
        public string BizItemId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("biz_item_name")]
        public string BizItemName { get; set; }

        /// <summary>
        /// 标识识别码
        /// </summary>
        [XmlElement("biz_src")]
        public string BizSrc { get; set; }

        /// <summary>
        /// 业务时间戳，用于解决请求乱序问题，如同时调用则会抛弃较早时间请求
        /// </summary>
        [XmlElement("biz_timestamp")]
        public long BizTimestamp { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 开始时间（生效）
        /// </summary>
        [XmlElement("gmt_active")]
        public string GmtActive { get; set; }

        /// <summary>
        /// 结束时间（过期）
        /// </summary>
        [XmlElement("gmt_expired")]
        public string GmtExpired { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        [XmlElement("img_url")]
        public string ImgUrl { get; set; }

        /// <summary>
        /// 订单总数量
        /// </summary>
        [XmlElement("number")]
        public long Number { get; set; }

        /// <summary>
        /// 外部订单ID
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 退款金额（单位分）
        /// </summary>
        [XmlElement("refund_amount")]
        public long RefundAmount { get; set; }

        /// <summary>
        /// 当前订单退款数量
        /// </summary>
        [XmlElement("refund_number")]
        public long RefundNumber { get; set; }

        /// <summary>
        /// 交易金额（单位分）
        /// </summary>
        [XmlElement("trade_amount")]
        public long TradeAmount { get; set; }

        /// <summary>
        /// 交易产生的时间
        /// </summary>
        [XmlElement("trade_dt")]
        public string TradeDt { get; set; }

        /// <summary>
        /// 当前订单核销数量
        /// </summary>
        [XmlElement("use_number")]
        public long UseNumber { get; set; }
    }
}
