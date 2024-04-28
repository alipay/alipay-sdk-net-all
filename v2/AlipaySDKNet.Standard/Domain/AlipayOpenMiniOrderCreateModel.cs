using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniOrderCreateModel : AopObject
    {
        /// <summary>
        /// 订单收货地址
        /// </summary>
        [XmlElement("address_info")]
        public MiniReceiverAddressInfoDTO AddressInfo { get; set; }

        /// <summary>
        /// 商户传入业务信息，具体值要和支付宝约定，应用于安全，营销等参数直传场景，格式为json格式
        /// </summary>
        [XmlElement("business_params")]
        public MiniBusinessParamsDTO BusinessParams { get; set; }

        /// <summary>
        /// 买家支付宝用户id，小程序场景下获取用户ID请参考：<a href="https://opendocs.alipay.com/mini/05dxgc?pathHash=1a3ecb13">用户授权</a>; 其它场景下获取用户ID请参考：<a href="https://opendocs.alipay.com/open/284/web">网页授权获取用户信息</a>。
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家支付宝登录账号。  buyer_logon_id和buyer_id两者传其一，和buyer_id不能同时为空，建议通过buyer_id来传递买家信息。
        /// </summary>
        [XmlElement("buyer_logon_id")]
        public string BuyerLogonId { get; set; }

        /// <summary>
        /// 买家支付宝用户唯一标识
        /// </summary>
        [XmlElement("buyer_open_id")]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// 买家联系人信息
        /// </summary>
        [XmlElement("contact_info")]
        public ContactInfoDTO ContactInfo { get; set; }

        /// <summary>
        /// 芝麻信息
        /// </summary>
        [XmlElement("credit_info")]
        public CreditInfoDTO CreditInfo { get; set; }

        /// <summary>
        /// 默认退货地址
        /// </summary>
        [XmlElement("default_receiving_address")]
        public MiniReceiverAddressInfoDTO DefaultReceivingAddress { get; set; }

        /// <summary>
        /// 物流信息--预留字段
        /// </summary>
        [XmlElement("delivery_detail")]
        public LogisticsInfoDTO DeliveryDetail { get; set; }

        /// <summary>
        /// 订单扩展字段
        /// </summary>
        [XmlElement("ext_info")]
        public MiniOrderExtInfoDTO ExtInfo { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        [XmlElement("merchant_biz_type")]
        public string MerchantBizType { get; set; }

        /// <summary>
        /// 订单信息
        /// </summary>
        [XmlElement("order_detail")]
        public MiniOrderDetailDTO OrderDetail { get; set; }

        /// <summary>
        /// 商户订单号，由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端不重复
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 商家小程序对应的订单详情页路径地址 value。仅需传入小程序页面路径即可。同一笔订单的链接必须与第一次传入的地址相同，且需是小程序内部页面路径
        /// </summary>
        [XmlElement("path")]
        public string Path { get; set; }

        /// <summary>
        /// 订单优惠信息
        /// </summary>
        [XmlElement("promo_detail_info")]
        public PromoDetailInfoDTO PromoDetailInfo { get; set; }

        /// <summary>
        /// 卖家支付宝用户ID。收款账号优先级规则：门店绑定的收款账户>请求传入的seller_id>商户签约账号对应的支付宝用户ID；  注：直付通和机构间联场景下seller_id无需传入或者保持跟pid一致；  如果传入的seller_id与pid不一致，需要联系支付宝小二配置收款关系；本地商品无需填写
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 门店信息
        /// </summary>
        [XmlElement("shop_info")]
        public ShopInfoDTO ShopInfo { get; set; }

        /// <summary>
        /// 追踪ID，公域分发场景必传，会影响主播归因、分享员归因等；通过调用 <a href="https://opendocs.alipay.com/mini/512c3ce1_my.checkBeforeAddOrder?pathHash=4b9d23c5">my.checkBeforeAddOrder</a> 接口返回
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 阶段付款计划，租赁场景或分期代扣场景，该字段必填
        /// </summary>
        [XmlArray("stage_pay_plans")]
        [XmlArrayItem("stage_pay_plan_d_t_o")]
        public List<StagePayPlanDTO> StagePayPlans { get; set; }

        /// <summary>
        /// 二级商户信息。 
        /// </summary>
        [XmlElement("sub_merchant")]
        public SubMerchantDTO SubMerchant { get; set; }

        /// <summary>
        /// 订单相对超时时间。从交易创建时间开始计算。 该笔订单允许的最晚付款时间，逾期将关闭交易。取值范围：1m～15d。m-分钟，h-小时，d-天。 该参数数值不接受小数点， 如 1.5h，可转换为  90m。 默认值为3h。
        /// </summary>
        [XmlElement("timeout_express")]
        public string TimeoutExpress { get; set; }

        /// <summary>
        /// 注意：不可使用特殊字符，如 /，=，& 等。
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
