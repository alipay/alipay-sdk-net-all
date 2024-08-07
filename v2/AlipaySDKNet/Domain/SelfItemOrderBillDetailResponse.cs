using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SelfItemOrderBillDetailResponse Data Structure.
    /// </summary>
    [Serializable]
    public class SelfItemOrderBillDetailResponse : AopObject
    {
        /// <summary>
        /// 订单凭证号
        /// </summary>
        [XmlElement("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 当前订单售卖凭证的原价，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("certificate_price")]
        public string CertificatePrice { get; set; }

        /// <summary>
        /// 凭证状态
        /// </summary>
        [XmlElement("certificate_status")]
        public string CertificateStatus { get; set; }

        /// <summary>
        /// 收费类目
        /// </summary>
        [XmlElement("fee_category")]
        public string FeeCategory { get; set; }

        /// <summary>
        /// 代运营服务商佣金，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("isv_alloc_amount")]
        public string IsvAllocAmount { get; set; }

        /// <summary>
        /// 代运营服务商名称
        /// </summary>
        [XmlElement("isv_name")]
        public string IsvName { get; set; }

        /// <summary>
        /// 核销商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品类型
        /// </summary>
        [XmlElement("item_type")]
        public string ItemType { get; set; }

        /// <summary>
        /// 商家优惠金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("merchant_discount_amount")]
        public string MerchantDiscountAmount { get; set; }

        /// <summary>
        /// 单笔履约关联的商家订单号
        /// </summary>
        [XmlElement("merchant_verification_no")]
        public string MerchantVerificationNo { get; set; }

        /// <summary>
        /// 小程序ID，标识当前返回的账单列表所属的小程序
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 平台订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 成交场景
        /// </summary>
        [XmlElement("order_scene")]
        public string OrderScene { get; set; }

        /// <summary>
        /// 商品的原始价格，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 支付手续费，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("pay_commission")]
        public string PayCommission { get; set; }

        /// <summary>
        /// 当前订单支付时优惠的金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("pay_discounted_price")]
        public string PayDiscountedPrice { get; set; }

        /// <summary>
        /// 支付宝优惠金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("platform_discount_amount")]
        public string PlatformDiscountAmount { get; set; }

        /// <summary>
        /// CPS技术服务费，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("platform_service")]
        public string PlatformService { get; set; }

        /// <summary>
        /// 退CPS技术服务费，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("platform_service_refund")]
        public string PlatformServiceRefund { get; set; }

        /// <summary>
        /// 预计CPS技术服务费，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("pre_cps_amount")]
        public string PreCpsAmount { get; set; }

        /// <summary>
        /// 预计代运营服务商佣金，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("pre_isv_alloc_amount")]
        public string PreIsvAllocAmount { get; set; }

        /// <summary>
        /// 预计商家优惠金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("pre_merchant_discount_amount")]
        public string PreMerchantDiscountAmount { get; set; }

        /// <summary>
        /// 预计支付手续费，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("pre_pay_commission")]
        public string PrePayCommission { get; set; }

        /// <summary>
        /// 预计支付宝优惠金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("pre_platform_discount_amount")]
        public string PrePlatformDiscountAmount { get; set; }

        /// <summary>
        /// 预计达人佣金，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("pre_public_alloc_amount")]
        public string PrePublicAllocAmount { get; set; }

        /// <summary>
        /// 预计saas服务商佣金，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("pre_saas_alloc_amount")]
        public string PreSaasAllocAmount { get; set; }

        /// <summary>
        /// 预计用户实付，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("pre_user_fund_amount")]
        public string PreUserFundAmount { get; set; }

        /// <summary>
        /// 订单预计结算时间
        /// </summary>
        [XmlElement("predict_settle_time")]
        public string PredictSettleTime { get; set; }

        /// <summary>
        /// 达人佣金，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("public_alloc_amount")]
        public string PublicAllocAmount { get; set; }

        /// <summary>
        /// 达人昵称
        /// </summary>
        [XmlElement("public_name")]
        public string PublicName { get; set; }

        /// <summary>
        /// 实收金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("real_receipt_amount")]
        public string RealReceiptAmount { get; set; }

        /// <summary>
        /// 退款金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("refund_fee")]
        public string RefundFee { get; set; }

        /// <summary>
        /// 退代运营服务商佣金，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("refund_isv_alloc_amount")]
        public string RefundIsvAllocAmount { get; set; }

        /// <summary>
        /// 退商家优惠，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("refund_merchant_discount_amount")]
        public string RefundMerchantDiscountAmount { get; set; }

        /// <summary>
        /// 退支付手续费，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("refund_pay_commission")]
        public string RefundPayCommission { get; set; }

        /// <summary>
        /// 退支付宝优惠，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("refund_platform_discount_amount")]
        public string RefundPlatformDiscountAmount { get; set; }

        /// <summary>
        /// 退达人佣金，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("refund_public_alloc_amount")]
        public string RefundPublicAllocAmount { get; set; }

        /// <summary>
        /// 退saas服务商佣金，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("refund_saas_alloc_amount")]
        public string RefundSaasAllocAmount { get; set; }

        /// <summary>
        /// 退先享后付商家版技术服务费，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("refund_service_amount")]
        public string RefundServiceAmount { get; set; }

        /// <summary>
        /// saas服务商佣金，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("saas_alloc_amount")]
        public string SaasAllocAmount { get; set; }

        /// <summary>
        /// saas服务商名称
        /// </summary>
        [XmlElement("saas_name")]
        public string SaasName { get; set; }

        /// <summary>
        /// 商家自有门店名称
        /// </summary>
        [XmlElement("self_shop_name")]
        public string SelfShopName { get; set; }

        /// <summary>
        /// 凭证核销的次序号  例：商品为次卡，可使用三次，则一个凭证能够进行三次核销，生成三个核销次序号
        /// </summary>
        [XmlElement("serial_no")]
        public string SerialNo { get; set; }

        /// <summary>
        /// 先享后付商家版技术服务费，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("service_amount")]
        public string ServiceAmount { get; set; }

        /// <summary>
        /// 结算到的银行卡号或支付宝账户
        /// </summary>
        [XmlElement("settle_account_no")]
        public string SettleAccountNo { get; set; }

        /// <summary>
        /// 结算账户类型，支付宝或银行卡
        /// </summary>
        [XmlElement("settle_account_type")]
        public string SettleAccountType { get; set; }

        /// <summary>
        /// 结算金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("settle_amount")]
        public string SettleAmount { get; set; }

        /// <summary>
        /// 结算时的批次号
        /// </summary>
        [XmlElement("settle_batch_id")]
        public string SettleBatchId { get; set; }

        /// <summary>
        /// 核销的商家自有门店id
        /// </summary>
        [XmlElement("settle_rel_shop_id")]
        public string SettleRelShopId { get; set; }

        /// <summary>
        /// 当前凭证的结算状态，下钻到次序号维度
        /// </summary>
        [XmlElement("settle_status")]
        public string SettleStatus { get; set; }

        /// <summary>
        /// 订单结算时间
        /// </summary>
        [XmlElement("settle_time")]
        public string SettleTime { get; set; }

        /// <summary>
        /// 当前交易订单关联的支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 核销员名称
        /// </summary>
        [XmlElement("use_user_name")]
        public string UseUserName { get; set; }

        /// <summary>
        /// 用户实付，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("user_fund_amount")]
        public string UserFundAmount { get; set; }

        /// <summary>
        /// 当前凭证核销门店的ID
        /// </summary>
        [XmlElement("verification_shop_id")]
        public string VerificationShopId { get; set; }

        /// <summary>
        /// 核销门店名称
        /// </summary>
        [XmlElement("verification_shop_name")]
        public string VerificationShopName { get; set; }

        /// <summary>
        /// 当前凭证核销时间
        /// </summary>
        [XmlElement("verification_time")]
        public string VerificationTime { get; set; }

        /// <summary>
        /// 核销时如发生付款行为（如自提卡业务），则返回此次交易对应的交易号
        /// </summary>
        [XmlElement("verification_trade_no")]
        public string VerificationTradeNo { get; set; }
    }
}
