using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReceiptOrderDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ReceiptOrderDTO : AopObject
    {
        /// <summary>
        /// 支付宝用户uid; 是支付宝支付时，必填
        /// </summary>
        [XmlElement("alipay_uid")]
        public string AlipayUid { get; set; }

        /// <summary>
        /// 订单金额，单位为元;
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 绿色能量发放归属的商户信息。 说明： 如果该复杂对象不填。则默认为该绿色能量发放的归属者是调用者本人。 如果填写，则认为该绿色能量发放的归属者是该商户。  限制:服务商身份接入时必传
        /// </summary>
        [XmlElement("belong_merchant_info")]
        public BelongMerchantInfoDTO BelongMerchantInfo { get; set; }

        /// <summary>
        /// 租借时长，精确到分钟;充电宝场景时，必填;
        /// </summary>
        [XmlElement("borrow_time")]
        public long BorrowTime { get; set; }

        /// <summary>
        /// 买家信息
        /// </summary>
        [XmlElement("buyer_info")]
        public UserInformation BuyerInfo { get; set; }

        /// <summary>
        /// 币种（CNY-人民币）
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 优惠金额。 如果为空，则默认都没有优惠金额
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 订单优惠信息;电子小票场景时，必填
        /// </summary>
        [XmlArray("discount_info_list")]
        [XmlArrayItem("discount_info_data_d_t_o")]
        public List<DiscountInfoDataDTO> DiscountInfoList { get; set; }

        /// <summary>
        /// 有对应环保类型 符合字段“environmental_ext"中的环保字典值时，则必填；除此之外的环保类型时，该字段为空。请务必准确对照，如有疑问，请联系业务经理。
        /// </summary>
        [XmlArray("environmental_info")]
        [XmlArrayItem("enviromental_info_d_t_o")]
        public List<EnviromentalInfoDTO> EnvironmentalInfo { get; set; }

        /// <summary>
        /// 临期食品商品列表，有临期食品时可填写，非必填。
        /// </summary>
        [XmlArray("good_expiration_list")]
        [XmlArrayItem("good_expiration_list_d_t_o")]
        public List<GoodExpirationListDTO> GoodExpirationList { get; set; }

        /// <summary>
        /// [          {             "cup_type": "zhiyinbei",             "cups_amount": "1"           }  ]
        /// </summary>
        [XmlArray("green_cups_list")]
        [XmlArrayItem("green_cups_d_t_o")]
        public List<GreenCupsDTO> GreenCupsList { get; set; }

        /// <summary>
        /// 商家开发票链接
        /// </summary>
        [XmlElement("invoice_entry")]
        public string InvoiceEntry { get; set; }

        /// <summary>
        /// 对接电子小票/无纸化小票能量发放时，必填; 其它场景，无需该字段; 字段含义: 是否接入支付宝电子小票; "0":不接入(商户自己有电子小票终端)；"1":接入; 接入场景:必须传入小票全量商品信息，用于在支付宝侧电子小票阵地展示给到C端用户;  不接入的商户且商户自己有终端实现了电子小票, 可以对接无纸化小票能量; 为空时，默认:"0"
        /// </summary>
        [XmlElement("is_alipay_ticket")]
        public string IsAlipayTicket { get; set; }

        /// <summary>
        /// 订单商品信息列表; 使用支付宝电子小票时，必填;（is_alipay_ticket 是 "1"时，必填）
        /// </summary>
        [XmlArray("item_order_list")]
        [XmlArrayItem("item_order_info_d_t_o")]
        public List<ItemOrderInfoDTO> ItemOrderList { get; set; }

        /// <summary>
        /// 设备地理位置及坐标; 充电宝场景时，必填
        /// </summary>
        [XmlElement("location")]
        public string Location { get; set; }

        /// <summary>
        /// 物流信息; 订单信息包含物流信息时，必填; 列表最多支持物流信息个数;最大支持10个 注：若该值不为空，且物流信息同步至我的快递，则在查询订单时可返回具体物流信息
        /// </summary>
        [XmlArray("logistics_info_list")]
        [XmlArrayItem("order_logistics_information_request_d_t_o")]
        public List<OrderLogisticsInformationRequestDTO> LogisticsInfoList { get; set; }

        /// <summary>
        /// 商户名字
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 订单创建时间; 充电宝和酒店行业时，必填; 时间格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 订单商品列表; 环保行为:临期商品，补充替换包装 、再生塑料包装、FSC认证包装、该商品列表必填
        /// </summary>
        [XmlArray("order_goods_list")]
        [XmlArrayItem("order_goods_d_t_o")]
        public List<OrderGoodsDTO> OrderGoodsList { get; set; }

        /// <summary>
        /// APPID,商户可自定义需要跳转到小程序（默认进入小程序首页）
        /// </summary>
        [XmlElement("order_link")]
        public string OrderLink { get; set; }

        /// <summary>
        /// 订单修改时间，一般不需要传入。用于订单状态或数据变化较快的顺序控制，order_modified_time较晚的同步会被最终存储，order_modified_time相同的两次同步可能会被幂等处理，FMCG按照行业标准化接入场景必须传入该字段控制乱序;时间格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("order_modified_time")]
        public string OrderModifiedTime { get; set; }

        /// <summary>
        /// 订单支付时间; 有支付行为时，必填; 没有支付时，为空; 时间格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("order_pay_time")]
        public string OrderPayTime { get; set; }

        /// <summary>
        /// 每次请求必传;所有订单类型枚举: 快消:FMCG; 酒店:HOTEL; 智能 售卖:AUTOMAT; 景区:RESORT;高校:HIGHSCHOOL;品牌: FASHION; 商圈综合体:MALL; 充电宝:POWERBANK; 物流:LOGISTICS
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 外部商户订单号;out_biz_no唯一对应一笔订单，相同的订单需传入相同的out_biz_no
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付金额，需要实际支付的金额。如果不涉及金额可不传入该字段，其他场景必填; 0元订单时，必填;
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 支付类型:alipay:支付宝，cashpay：现金，otherpay：其它; 支付宝支付时，必填;  森林能量发放仅支持支付宝支付("alipay")和0元订单("otherpay")
        /// </summary>
        [XmlElement("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 门店地址
        /// </summary>
        [XmlElement("shop_address")]
        public string ShopAddress { get; set; }

        /// <summary>
        /// 门店联系方式
        /// </summary>
        [XmlElement("shop_contract")]
        public string ShopContract { get; set; }

        /// <summary>
        /// 门店名称; 拥有门店的场景时，必填; 否则无法展示门店信息
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 提供字典值
        /// </summary>
        [XmlElement("shop_type")]
        public string ShopType { get; set; }

        /// <summary>
        /// 终端设备id;直饮水订单时，必填
        /// </summary>
        [XmlElement("terminal_id")]
        public string TerminalId { get; set; }

        /// <summary>
        /// 订单所对应的支付宝交易号，酒店6小件场景时,传入履约号; 支付宝支付时，必填; 特殊情况: 0元订单, 可不填; 无支付场景时，可不填;
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易号类型:1. TRADE-交易，为空默认为TRADE;2. TRANSFER-转账;3. ENTRUST-受托;4.(酒店)履约-CONTRACT
        /// </summary>
        [XmlElement("trade_type")]
        public string TradeType { get; set; }
    }
}
