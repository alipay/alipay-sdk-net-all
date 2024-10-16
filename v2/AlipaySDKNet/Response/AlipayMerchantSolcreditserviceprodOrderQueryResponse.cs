using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantSolcreditserviceprodOrderQueryResponse.
    /// </summary>
    public class AlipayMerchantSolcreditserviceprodOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("billing_end_time")]
        public string BillingEndTime { get; set; }

        /// <summary>
        /// yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("billing_start_time")]
        public string BillingStartTime { get; set; }

        /// <summary>
        /// 纯免押: DEPOSIT_FREE; 固定租金: FIXED_RENT;动态租金: DYNAMIC_RENT; 周期付: PERIOD_PAY
        /// </summary>
        [XmlElement("credit_service_type")]
        public string CreditServiceType { get; set; }

        /// <summary>
        /// 违约金额(单位元),最多支持2位小数
        /// </summary>
        [XmlElement("default_amount")]
        public string DefaultAmount { get; set; }

        /// <summary>
        /// 押金金额(单位元)，最多支持2位小数
        /// </summary>
        [XmlElement("deposit_amount")]
        public string DepositAmount { get; set; }

        /// <summary>
        /// 动态租金必填
        /// </summary>
        [XmlElement("dynamic_rent_billing_rule")]
        public DynamicRentBillingRuleDTO DynamicRentBillingRule { get; set; }

        /// <summary>
        /// 固定租金必填
        /// </summary>
        [XmlElement("fixed_rent_billing_rule")]
        public FixedRentBillingRuleDTO FixedRentBillingRule { get; set; }

        /// <summary>
        /// 开单使用的小程序ID
        /// </summary>
        [XmlElement("merchant_app_id")]
        public string MerchantAppId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("order_end_time")]
        public string OrderEndTime { get; set; }

        /// <summary>
        /// 系统生成订单唯一编号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 初始化: INIT;待开始: WAIT_START;使用中: IN_USE; 取消: CANCEL; 完结中: ENDING; 已完结: ENDED
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 商家下单时自定义编号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 周期付租金必填
        /// </summary>
        [XmlElement("period_pay_billing_rule")]
        public PeriodPayBillingRuleDTO PeriodPayBillingRule { get; set; }

        /// <summary>
        /// 系统生成的商品编号
        /// </summary>
        [XmlElement("product_no")]
        public string ProductNo { get; set; }

        /// <summary>
        /// 直付通进件得到的ID
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("u_open_id")]
        public string UOpenId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("zm_sign_time")]
        public string ZmSignTime { get; set; }
    }
}
