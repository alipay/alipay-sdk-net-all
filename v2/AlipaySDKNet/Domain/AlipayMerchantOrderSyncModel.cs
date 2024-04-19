using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantOrderSyncModel : AopObject
    {
        /// <summary>
        /// 订单总金额：某笔交易订单优惠前的总金额，单位为【元】</br> <a href="https://mdn.alipayobjects.com/portal_ykdvdu/afts/img/A*UuuWRpmekegAAAAAAAAAAAAAAQAAAQ/original" target="_blank">实际案例一</a> <br><a href="https://mdn.alipayobjects.com/portal_ykdvdu/afts/img/A*kBkOTZpqP40AAAAAAAAAAAAAAQAAAQ/original" target="_blank">实际案例二</a> <br><a href="https://mdn.alipayobjects.com/portal_ykdvdu/afts/img/A*ZpkjTJQlFVAAAAAAAAAAAAAAAQAAAQ/original" target="_blank">实际案例三</a>
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 买家userId
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家信息
        /// </summary>
        [XmlElement("buyer_info")]
        public UserInfomation BuyerInfo { get; set; }

        /// <summary>
        /// 用户open_id
        /// </summary>
        [XmlElement("buyer_open_id")]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// 标准服务类目
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 商户总计优惠金额：代表商户侧给予用户的总计优惠金额 （不包含选择支付宝付款时，支付宝给予的优惠减免金额），单位为【元】。</br> <a href="https://mdn.alipayobjects.com/portal_ykdvdu/afts/img/A*UuuWRpmekegAAAAAAAAAAAAAAQAAAQ/original" target="_blank">实际案例一</a> <br><a href="https://mdn.alipayobjects.com/portal_ykdvdu/afts/img/A*kBkOTZpqP40AAAAAAAAAAAAAAQAAAQ/original" target="_blank">实际案例二</a> <br><a href="https://mdn.alipayobjects.com/portal_ykdvdu/afts/img/A*ZpkjTJQlFVAAAAAAAAAAAAAAAQAAAQ/original" target="_blank">实际案例三</a>
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 订单优惠信息
        /// </summary>
        [XmlArray("discount_info_list")]
        [XmlArrayItem("discount_info_data")]
        public List<DiscountInfoData> DiscountInfoList { get; set; }

        /// <summary>
        /// 扩展信息，请参见 <a href="https://opendocs.alipay.com/mini/04zsxt?pathHash=654d4f10">小程序订单中心模板</a>
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("order_ext_info")]
        public List<OrderExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 商品信息列表
        /// </summary>
        [XmlArray("item_order_list")]
        [XmlArrayItem("item_order_info")]
        public List<ItemOrderInfo> ItemOrderList { get; set; }

        /// <summary>
        /// 行程信息
        /// </summary>
        [XmlArray("journey_order_list")]
        [XmlArrayItem("order_journey_info")]
        public List<OrderJourneyInfo> JourneyOrderList { get; set; }

        /// <summary>
        /// 物流信息列表
        /// </summary>
        [XmlArray("logistics_info_list")]
        [XmlArrayItem("order_logistics_information_request")]
        public List<OrderLogisticsInformationRequest> LogisticsInfoList { get; set; }

        /// <summary>
        /// 本字段已废弃，无需填写！ 当前字段已废弃(本字段已废弃 不再使用)
        /// </summary>
        [XmlElement("order_auth_code")]
        public string OrderAuthCode { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 订单修改时间
        /// </summary>
        [XmlElement("order_modified_time")]
        public string OrderModifiedTime { get; set; }

        /// <summary>
        /// 订单支付时间
        /// </summary>
        [XmlElement("order_pay_time")]
        public string OrderPayTime { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 外部订单号 out_biz_no唯一对应一笔订单，相同的订单需传入相同的out_biz_no
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 交易对应的签约商户userId 当前字段已废弃(注意：该字段自2020-02-16日起，可以不传入)
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 用户应付金额 ：用户最终结算时需要支付金额（不包含选择支付宝付款时，支付宝给予的优惠减免金额），单位为【元】</br> <a href="https://mdn.alipayobjects.com/portal_ykdvdu/afts/img/A*UuuWRpmekegAAAAAAAAAAAAAAQAAAQ/original" target="_blank">实际案例一</a> <br><a href="https://mdn.alipayobjects.com/portal_ykdvdu/afts/img/A*kBkOTZpqP40AAAAAAAAAAAAAAQAAAQ/original" target="_blank">实际案例二</a> <br><a href="https://mdn.alipayobjects.com/portal_ykdvdu/afts/img/A*ZpkjTJQlFVAAAAAAAAAAAAAAAQAAAQ/original" target="_blank">实际案例三</a>
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 支付超时时间，超过时间支付宝自行关闭订单
        /// </summary>
        [XmlElement("pay_timeout_express")]
        public string PayTimeoutExpress { get; set; }

        /// <summary>
        /// 商户订单同步记录id 当前字段已废弃(仅部分存量接入和行业模板需要外，其他情况可以不传入)
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 卖家userId 当前字段已废弃(注意：该字段自2020-02-16日起，可以不传入)
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 是否需要小程序订单代理发送模版消息。不传默认不发送
        /// </summary>
        [XmlElement("send_msg")]
        public string SendMsg { get; set; }

        /// <summary>
        /// 服务code：传入小程序后台提报的服务id，将订单与服务关联，有利于提高服务曝光机会；入参服务id的类目须与订单类型相符，若不相符将会报错；如订单类型为“外卖”，则入参的服务ID所对应的服务类目也必须得是”外卖“；service_code 通过 <a href="https://opendocs.alipay.com/mini/e1c835a1_alipay.open.app.service.apply" target="_blank">alipay.open.app.service.apply</a> ，(服务提报申请)接口创建服务后获取。
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 门店信息，扫码点餐获取返佣时必填。
        /// </summary>
        [XmlElement("shop_info")]
        public OrderShopInfo ShopInfo { get; set; }

        /// <summary>
        /// 用于区分用户下单的订单来源
        /// </summary>
        [XmlElement("source_app")]
        public string SourceApp { get; set; }

        /// <summary>
        /// 同步内容
        /// </summary>
        [XmlElement("sync_content")]
        public string SyncContent { get; set; }

        /// <summary>
        /// 凭证信息（废弃，凭证信息参考ticket_order_list） 当前字段已废弃(可使用 ticket_order_list 替代)
        /// </summary>
        [XmlElement("ticket_info")]
        public TicketInfo TicketInfo { get; set; }

        /// <summary>
        /// 凭证信息
        /// </summary>
        [XmlArray("ticket_order_list")]
        [XmlArrayItem("ticket_order_info")]
        public List<TicketOrderInfo> TicketOrderList { get; set; }

        /// <summary>
        /// 订单所对应的支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易号类型
        /// </summary>
        [XmlElement("trade_type")]
        public string TradeType { get; set; }
    }
}
