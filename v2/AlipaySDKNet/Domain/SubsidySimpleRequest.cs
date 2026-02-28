using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubsidySimpleRequest Data Structure.
    /// </summary>
    [Serializable]
    public class SubsidySimpleRequest : AopObject
    {
        /// <summary>
        /// 收单模式（淘外场景使用）
        /// </summary>
        [XmlElement("acquire_mode")]
        public string AcquireMode { get; set; }

        /// <summary>
        /// 资产类型编码
        /// </summary>
        [XmlElement("asset_type_code")]
        public string AssetTypeCode { get; set; }

        /// <summary>
        /// 一级业务标识
        /// </summary>
        [XmlElement("biz_identity")]
        public string BizIdentity { get; set; }

        /// <summary>
        /// 用户id，即付款方（亲密付类似场景预留字段）
        /// </summary>
        [XmlElement("buyer_user_id")]
        public string BuyerUserId { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("good_item_id")]
        public string GoodItemId { get; set; }

        /// <summary>
        /// 分期期数
        /// </summary>
        [XmlArray("install_nums")]
        [XmlArrayItem("string")]
        public List<string> InstallNums { get; set; }

        /// <summary>
        /// 分期贴息参数
        /// </summary>
        [XmlElement("installment_biz_info")]
        public string InstallmentBizInfo { get; set; }

        /// <summary>
        /// 第三方出资id（主子店铺场景预留字段）
        /// </summary>
        [XmlElement("investor_id")]
        public string InvestorId { get; set; }

        /// <summary>
        /// 国际链路中能够唯一区分二级商户粒度的独立字段。由unitradeprod进行拼接。
        /// </summary>
        [XmlElement("ipay_secmerchant")]
        public string IpaySecmerchant { get; set; }

        /// <summary>
        /// 是否合并支付2.0
        /// </summary>
        [XmlElement("merge_pay")]
        public bool MergePay { get; set; }

        /// <summary>
        /// 内部门店id。直连、国内间连有使用。（含义不清楚，待定）
        /// </summary>
        [XmlElement("mshop_id")]
        public string MshopId { get; set; }

        /// <summary>
        /// 本笔交易订单金额
        /// </summary>
        [XmlElement("order_amount")]
        public SubsidyMoney OrderAmount { get; set; }

        /// <summary>
        /// 原始商户id。目前国际站全3链路才有使用，入驻全球站的机构或直连商户ID
        /// </summary>
        [XmlElement("original_mid")]
        public string OriginalMid { get; set; }

        /// <summary>
        /// 原始卖家id。目前国际站全3链路才有使用，机构分配商户的ID（全球站）
        /// </summary>
        [XmlElement("original_seller_id")]
        public string OriginalSellerId { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 商家pid
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 一般指同一个商家 会有多个平台载体(直接管控商品或承载商户入驻)，如taobao，tmall  * 淘系一般都有值，淘外一般为空。
        /// </summary>
        [XmlElement("platform")]
        public string Platform { get; set; }

        /// <summary>
        /// 业务平台类型
        /// </summary>
        [XmlElement("platform_type")]
        public string PlatformType { get; set; }

        /// <summary>
        /// 销售产品码 与deliveryProductCode含义 （淘外场景使用）
        /// </summary>
        [XmlElement("sales_product_code")]
        public string SalesProductCode { get; set; }

        /// <summary>
        /// 贴息禁用能力新增字段值 用于判断当前场景类型
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 二级商户id（淘外场景使用）
        /// </summary>
        [XmlElement("secondary_merchant_id")]
        public string SecondaryMerchantId { get; set; }

        /// <summary>
        /// 商家sellerId
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 门店id。直连、国内间连、国际间连都有使用。
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 子业务平台类型，platformType下的子业务频道（预留字段）
        /// </summary>
        [XmlElement("sub_platform_type")]
        public string SubPlatformType { get; set; }

        /// <summary>
        /// 贴息产品化场景编码
        /// </summary>
        [XmlElement("subsidy_biz_code")]
        public string SubsidyBizCode { get; set; }

        /// <summary>
        /// 如果是合并支付，对应的所有订单总金额
        /// </summary>
        [XmlElement("total_amount")]
        public SubsidyMoney TotalAmount { get; set; }

        /// <summary>
        /// 交易订单号
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
