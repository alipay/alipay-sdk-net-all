using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentOrderPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentOrderPayModel : AopObject
    {
        /// <summary>
        /// 租赁售后单号
        /// </summary>
        [XmlElement("aftersale_id")]
        public string AftersaleId { get; set; }

        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 租金支付外部请求号，由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端不重复。
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 支付金额，单位：元，精确到小数点后两位。
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 订单费用项明细列表
        /// </summary>
        [XmlArray("pay_items")]
        [XmlArrayItem("rent_pay_item_d_t_o")]
        public List<RentPayItemDTO> PayItems { get; set; }

        /// <summary>
        /// 支付方式
        /// </summary>
        [XmlElement("pay_method")]
        public string PayMethod { get; set; }

        /// <summary>
        /// 支付宝服务器主动通知商户服务器里指定的页面http/https路径
        /// </summary>
        [XmlElement("pay_notify_url")]
        public string PayNotifyUrl { get; set; }

        /// <summary>
        /// 从交易创建时间开始计算。 该笔支付允许的最晚付款时间，逾期将关闭交易。取值范围：1m～15d。m-分钟，h-小时，d-天。 该参数数值不接受小数点， 如 1.5h，可转换为 90m。 租赁代扣默认值为5m、JSAPI支付默认值30m
        /// </summary>
        [XmlElement("pay_timeout_express")]
        public string PayTimeoutExpress { get; set; }

        /// <summary>
        /// 扣款原因编码
        /// </summary>
        [XmlElement("reason_code")]
        public string ReasonCode { get; set; }

        /// <summary>
        /// 扣款原因说明
        /// </summary>
        [XmlElement("reason_desc")]
        public string ReasonDesc { get; set; }
    }
}
