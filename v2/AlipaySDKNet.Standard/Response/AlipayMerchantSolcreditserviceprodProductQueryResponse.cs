using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantSolcreditserviceprodProductQueryResponse.
    /// </summary>
    public class AlipayMerchantSolcreditserviceprodProductQueryResponse : AopResponse
    {
        /// <summary>
        /// 纯免押: DEPOSIT_FREE; 固定租金: FIXED_RENT;动态租金: DYNAMIC_RENT; 周期付: PERIOD_PAY
        /// </summary>
        [XmlElement("credit_service_type")]
        public string CreditServiceType { get; set; }

        /// <summary>
        /// 押金金额(单位元)，商品对应押金金额，免押金额
        /// </summary>
        [XmlElement("deposit_amount")]
        public string DepositAmount { get; set; }

        /// <summary>
        /// 商品详情描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

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
        /// yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 商家编辑商品时自定义的编号
        /// </summary>
        [XmlElement("out_product_no")]
        public string OutProductNo { get; set; }

        /// <summary>
        /// 周期付租金必填
        /// </summary>
        [XmlElement("period_pay_billing_rule")]
        public PeriodPayBillingRuleDTO PeriodPayBillingRule { get; set; }

        /// <summary>
        /// 非纯免押场景必填
        /// </summary>
        [XmlElement("post_payment_name")]
        public string PostPaymentName { get; set; }

        /// <summary>
        /// 需要使用通用图片上传接口返回的链接
        /// </summary>
        [XmlElement("product_cover_pic_url")]
        public string ProductCoverPicUrl { get; set; }

        /// <summary>
        /// 商家自定义
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 系统生成的商品编号
        /// </summary>
        [XmlElement("product_no")]
        public string ProductNo { get; set; }

        /// <summary>
        /// 待上架: WAIT_UP; 已上架: PRODUCT_UP;已下架: PRODUCT_DOWN
        /// </summary>
        [XmlElement("product_status")]
        public string ProductStatus { get; set; }

        /// <summary>
        /// 使用规则
        /// </summary>
        [XmlElement("purchase_note")]
        public string PurchaseNote { get; set; }

        /// <summary>
        /// 风控类目code
        /// </summary>
        [XmlElement("scene_category_code")]
        public string SceneCategoryCode { get; set; }

        /// <summary>
        /// 直付通进件得到的ID
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
