using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportAirticketOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportAirticketOrderSyncModel : AopObject
    {
        /// <summary>
        /// 订单总金额，币种：人民币，单位：元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 订单业务场景，由支付宝侧定义
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 订单业务类型，由支付宝侧定义
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 支付宝用户openid，如果商户开通了openid，建议传入 如使用open_id，请确认「应用-开发配置-openid配置管理」已启用
        /// </summary>
        [XmlElement("buyer_openid")]
        public string BuyerOpenid { get; set; }

        /// <summary>
        /// 下单的支付宝用户uid，2088开头的数字串
        /// </summary>
        [XmlElement("buyer_uid")]
        public string BuyerUid { get; set; }

        /// <summary>
        /// 订单抽佣渠道，由支付宝侧定义
        /// </summary>
        [XmlElement("commission_channel")]
        public string CommissionChannel { get; set; }

        /// <summary>
        /// 辅营商品信息
        /// </summary>
        [XmlArray("commodity_info_list")]
        [XmlArrayItem("traffic_airticket_order_commodity_info")]
        public List<TrafficAirticketOrderCommodityInfo> CommodityInfoList { get; set; }

        /// <summary>
        /// 订单创建时间，该笔订单真实的创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 优惠金额，币种：人民币，单位：元
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 优惠项目信息
        /// </summary>
        [XmlArray("discount_info_list")]
        [XmlArrayItem("traffic_airticket_order_discount_info")]
        public List<TrafficAirticketOrderDiscountInfo> DiscountInfoList { get; set; }

        /// <summary>
        /// 订单页面的跳转链接
        /// </summary>
        [XmlElement("link_page")]
        public string LinkPage { get; set; }

        /// <summary>
        /// 订单修改时间，订单状态或内容发生变更时需要同步更新该时间
        /// </summary>
        [XmlElement("modified_time")]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// 原始订单号，如果因为某些原因重新生成订单，关联的变化前订单的外部订单号
        /// </summary>
        [XmlElement("ori_out_biz_no")]
        public string OriOutBizNo { get; set; }

        /// <summary>
        /// 外部订单号，由商家自定义
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 乘机人四要素加密信息列表，其中的certType证件号和手机号经过了对称加密密钥加密过
        /// </summary>
        [XmlArray("passenger_info_encrypted_list")]
        [XmlArrayItem("traffic_air_ticket_passenger_encrypted_info")]
        public List<TrafficAirTicketPassengerEncryptedInfo> PassengerInfoEncryptedList { get; set; }

        /// <summary>
        /// 乘机人信息
        /// </summary>
        [XmlArray("passenger_info_list")]
        [XmlArrayItem("traffic_airticket_order_passenger_info")]
        public List<TrafficAirticketOrderPassengerInfo> PassengerInfoList { get; set; }

        /// <summary>
        /// 订单实际支付金额，币种：人民币，单位：元
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 订单来源渠道，请在支付宝给出的枚举中选择使用
        /// </summary>
        [XmlElement("source_channel")]
        public string SourceChannel { get; set; }

        /// <summary>
        /// 来源渠道标识，与source_channel关联，取值逻辑由双方约定
        /// </summary>
        [XmlElement("source_channel_id")]
        public string SourceChannelId { get; set; }

        /// <summary>
        /// 订单状态code
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 订单状态描述
        /// </summary>
        [XmlElement("status_desc")]
        public string StatusDesc { get; set; }

        /// <summary>
        /// 支付宝交易号，若传递trade_no，则该订单的后续状态更新时都需要传递trade_no
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
