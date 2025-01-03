using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudTraasCloudriskRentriskQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudTraasCloudriskRentriskQueryModel : AopObject
    {
        /// <summary>
        /// 身份证号 当前字段已废弃(请使用 customer_type 和 customer_id 参数)
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 客户详情
        /// </summary>
        [XmlElement("customer_detail")]
        public RentCustomerDetail CustomerDetail { get; set; }

        /// <summary>
        /// 客户唯一标识： 当 customer_type = MOBILE 时，填写11位手机号； 当 customer_type = CERT_NO 时，填写18位或15位身份证号； 当 customer_type = MOBILE_SHA256 时，填写手机号的 SHA256 值； 当 customer_type = CERT_NO_SHA256 时，填写证件号的 SHA256 值； 当 customer_type = ALIPAY_USER_ID 时，填写支付宝账户 UserId； 当 customer_type = ALIPAY_OPEN_ID 时，填写支付宝账户 OpenId
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 客户支付宝OpenId 当前字段已废弃(针对用户标识字段，在入参上做收口，建议统一用customer_id+customer_type的方式)
        /// </summary>
        [XmlElement("customer_open_id")]
        public string CustomerOpenId { get; set; }

        /// <summary>
        /// 客户标识类型
        /// </summary>
        [XmlElement("customer_type")]
        public string CustomerType { get; set; }

        /// <summary>
        /// 配送详情
        /// </summary>
        [XmlElement("delivery_detail")]
        public RentDeliveryDetail DeliveryDetail { get; set; }

        /// <summary>
        /// 商品详情
        /// </summary>
        [XmlElement("item_detail")]
        public RentItemDetail ItemDetail { get; set; }

        /// <summary>
        /// 手机号 当前字段已废弃(请使用 customer_type 和 customer_id 参数)
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 外部订单号，商家需保证在商户端不重复。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 价格详情
        /// </summary>
        [XmlElement("price_detail")]
        public RentPriceDetail PriceDetail { get; set; }

        /// <summary>
        /// 风险业务场景
        /// </summary>
        [XmlElement("risk_biz_scene")]
        public string RiskBizScene { get; set; }

        /// <summary>
        /// 订单下单渠道
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 用户授权
        /// </summary>
        [XmlElement("user_authorization")]
        public string UserAuthorization { get; set; }
    }
}
