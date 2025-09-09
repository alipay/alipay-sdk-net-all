using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppOrderCreateModel : AopObject
    {
        /// <summary>
        /// 芝麻信息
        /// </summary>
        [XmlElement("credit_info")]
        public CreditInfoDTO CreditInfo { get; set; }

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
        /// 当需要指定收款账号时，通过该参数传入，如果该值为空，则默认为商户签约账号对应的支付宝用户ID。  收款账号优先级规则：门店绑定的收款账户>请求传入的seller_id>商户签约账号对应的支付宝用户ID；  注：直付通和机构间联场景下seller_id无需传入或者保持跟pid一致；  如果传入的seller_id与pid不一致，需要联系支付宝小二配置收款关系；本地商品无需填写
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 订单服务类型
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 阶段付款计划
        /// </summary>
        [XmlElement("stage_pay_plans")]
        public StagePayPlanDTO StagePayPlans { get; set; }

        /// <summary>
        /// 二级商户信息
        /// </summary>
        [XmlElement("sub_merchant")]
        public SubMerchantDTO SubMerchant { get; set; }

        /// <summary>
        /// 注意：不可使用特殊字符，如 /，=，& 等。
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
