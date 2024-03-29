using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantOrderMessageSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantOrderMessageSyncModel : AopObject
    {
        /// <summary>
        /// 提交到支付的金额，可描述积分价钱类型，如订单金额，可描述积分价钱类型，如[{type: MONEY, amount: 31.08},{type: ALIPAY_POINT, amount: 88}]
        /// </summary>
        [XmlArray("actual_amount")]
        [XmlArrayItem("price_information")]
        public List<PriceInformation> ActualAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("alipay_trade_no")]
        public string AlipayTradeNo { get; set; }

        /// <summary>
        /// 平台订单号，如tp平台订单号
        /// </summary>
        [XmlElement("biz_order_no")]
        public string BizOrderNo { get; set; }

        /// <summary>
        /// 一级业务身份/行业，如在飞猪有机票、酒店、门票等细分的行业
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 经营单元信息，如门店信息，identity: 6792889042, type: UNIFY_STORE_ID, name: 深夜食堂
        /// </summary>
        [XmlElement("biz_unit_info")]
        public BizUnitInfo BizUnitInfo { get; set; }

        /// <summary>
        /// 一般用作支付宝买家，type: USER_ID, issuer: ALIPAY, identity: 2088102556225661
        /// </summary>
        [XmlElement("buyer")]
        public UserIdentity Buyer { get; set; }

        /// <summary>
        /// 回查商户数据的链接
        /// </summary>
        [XmlElement("callback_url")]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 履约状态枚举，如DELIVERIND/DELIVERED
        /// </summary>
        [XmlElement("deliver_status")]
        public string DeliverStatus { get; set; }

        /// <summary>
        /// 履约状态文案
        /// </summary>
        [XmlElement("deliver_status_desc")]
        public string DeliverStatusDesc { get; set; }

        /// <summary>
        /// 扩展信息，如ORDER_FROM/ORDER_CHANNEL/EXTERNAL_PID
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("order_ext_info")]
        public List<OrderExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 外部买家，type: USER_ID, issuer: TAOBAO, identity: 75438909432
        /// </summary>
        [XmlElement("external_buyer")]
        public UserIdentity ExternalBuyer { get; set; }

        /// <summary>
        /// 关联的外部订单号，如tp平台关联的飞猪交易号
        /// </summary>
        [XmlElement("external_order_no")]
        public string ExternalOrderNo { get; set; }

        /// <summary>
        /// 外部卖家，如type: USER_ID, issuer: TAOBAO, identity: 746239043226
        /// </summary>
        [XmlElement("external_seller")]
        public UserIdentity ExternalSeller { get; set; }

        /// <summary>
        /// 主商品名称/商品集合名称
        /// </summary>
        [XmlElement("item_title")]
        public string ItemTitle { get; set; }

        /// <summary>
        /// 订单修改时间，用于控制乱序。如果主订单时间没修改但是履约单时间修改了，需要传履约单最新的修改时间过来，否则会被判断为已经处理过
        /// </summary>
        [XmlElement("modify_time")]
        public string ModifyTime { get; set; }

        /// <summary>
        /// 订单金额，可描述积分价钱类型，如[{type: MONEY, amount: 32.58},{type: ALIPAY_POINT, amount: 88}]
        /// </summary>
        [XmlArray("order_amount")]
        [XmlArrayItem("price_information")]
        public List<PriceInformation> OrderAmount { get; set; }

        /// <summary>
        /// 状态枚举，如PAID/DELIVERED
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 状态文案，一般必选，如有特殊接入场景无法传入需单独沟通
        /// </summary>
        [XmlElement("order_status_desc")]
        public string OrderStatusDesc { get; set; }

        /// <summary>
        /// 平台商的支付宝ID，如tp在支付宝的pid
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 支付状态枚举，如WAIT_PAY/PAID/CLOSED
        /// </summary>
        [XmlElement("pay_status")]
        public string PayStatus { get; set; }

        /// <summary>
        /// 支付状态文案
        /// </summary>
        [XmlElement("pay_status_desc")]
        public string PayStatusDesc { get; set; }

        /// <summary>
        /// 订单支付成功时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 退款状态枚举，如PROCESSING/REFUNDED
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 退款状态文案
        /// </summary>
        [XmlElement("refund_status_desc")]
        public string RefundStatusDesc { get; set; }

        /// <summary>
        /// 一般用作支付宝卖家，type: USER_ID, issuer: ALIPAY, identity: 2088102146225135
        /// </summary>
        [XmlElement("seller")]
        public UserIdentity Seller { get; set; }

        /// <summary>
        /// 业务来源/经济体，如trip、eleme、koubei、hema、film、damai等
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 二级业务身份，类似于类目层级中的业务类目，如飞猪机票国内ali.china.trip.airticket.inland，飞猪机票国外ali.china.trip.airticket.abroad.hl
        /// </summary>
        [XmlElement("sub_biz_type")]
        public string SubBizType { get; set; }

        /// <summary>
        /// 调用方系统名称
        /// </summary>
        [XmlElement("system_name")]
        public string SystemName { get; set; }
    }
}
