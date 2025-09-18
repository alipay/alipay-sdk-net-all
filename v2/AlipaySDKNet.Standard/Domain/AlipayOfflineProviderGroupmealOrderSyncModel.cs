using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderGroupmealOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderGroupmealOrderSyncModel : AopObject
    {
        /// <summary>
        /// 开通企业码后的共享账户ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 商家侧订单实际金额，金额单位:元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 设备的SN信息
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 商家侧订单优惠金额，金额单位：元
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 企业码生成的企业ID，企业码用户产生的该字段必须传，否则影响企业码返佣
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 订单所包含的商品名称
        /// </summary>
        [XmlElement("good_name")]
        public string GoodName { get; set; }

        /// <summary>
        /// 服务商pid
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 商户小程序对应的订单详情页路径地址 value。仅需传入小程序页面路径即可。小程序页面路径规则见请求参数示例-小程序页面url说明
        /// </summary>
        [XmlElement("merchant_order_link_page")]
        public string MerchantOrderLinkPage { get; set; }

        /// <summary>
        /// 订单的状态
        /// </summary>
        [XmlElement("merchant_order_status")]
        public string MerchantOrderStatus { get; set; }

        /// <summary>
        /// 商家pid信息
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 商户小程序对应的充值页路径地址 value。仅需传入小程序页面路径即可。小程序页面路径规则见请求参数示例-小程序页面url说明
        /// </summary>
        [XmlElement("merchant_recharge_link_page")]
        public string MerchantRechargeLinkPage { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单业务扩展信息
        /// </summary>
        [XmlElement("order_business_info")]
        public OrderBusinessInfo OrderBusinessInfo { get; set; }

        /// <summary>
        /// 商家侧订单实际创建时间，时间格式为 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 订单修改时间，时间格式为 yyyy-MM-dd HH:mm:ss，订单状态或内容发生变更时需要同步更新该时间。
        /// </summary>
        [XmlElement("order_modified_time")]
        public string OrderModifiedTime { get; set; }

        /// <summary>
        /// 商家侧订单实际支付时间，时间格式为 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("order_pay_time")]
        public string OrderPayTime { get; set; }

        /// <summary>
        /// 企业/高校库ID，对应orgId 或 logidGroupid
        /// </summary>
        [XmlElement("org_id")]
        public string OrgId { get; set; }

        /// <summary>
        /// 外部订单号。由商家自定义。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商家侧订单实际支付金额，金额单位为元
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 支付时的支付类别
        /// </summary>
        [XmlElement("payment_type")]
        public string PaymentType { get; set; }

        /// <summary>
        /// 用于记录支付所需的凭证信息，比如28码
        /// </summary>
        [XmlElement("payment_voucher")]
        public string PaymentVoucher { get; set; }

        /// <summary>
        /// 商家小程序appId
        /// </summary>
        [XmlElement("tiny_app_id")]
        public string TinyAppId { get; set; }

        /// <summary>
        /// 商家侧订单使用支付宝支付时，对应的支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
