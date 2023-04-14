using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaymentVoucherDisplayInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PaymentVoucherDisplayInfo : AopObject
    {
        /// <summary>
        /// 商户品牌名称。 如果不设置品牌名称，则默认使用支付宝商家系统中维护的商家别名。 如果没有维护商家别名，则使用默认名称： 商家优惠。 用户领取优惠券后，品牌名称会对用户进行展示
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 商家客服电话，会展示在支付宝卡包券详情页。
        /// </summary>
        [XmlElement("customer_service_mobile")]
        public string CustomerServiceMobile { get; set; }

        /// <summary>
        /// 用于说明详细的活动规则，会展示在支付宝卡包券详情页。
        /// </summary>
        [XmlElement("voucher_description")]
        public string VoucherDescription { get; set; }

        /// <summary>
        /// 券详细图列表，会展示在用户支付宝卡包券详情页 需要通过 alipay.marketing.material.image.upload接口上传图片，指定file_key为PROMO_VOUCHER_DETAIL_IMAGE ,接口返回的resource_id即为该参数的值 上传图片尺寸600*600，支持格式：png、jpg、jpeg、bmp，大小不超过2MB 限制 1.voucher_image填入，该值才能填入； 2.最多3张；
        /// </summary>
        [XmlArray("voucher_detail_images")]
        [XmlArrayItem("string")]
        public List<string> VoucherDetailImages { get; set; }

        /// <summary>
        /// 券详情页封面图，会展示在用户支付宝卡包券详情页 需要通过 alipay.marketing.material.image.upload接口上传图片，指定file_key为PROMO_VOUCHER_IMAGE，接口返回的resource_id即为该参数的值 限制: 该字段在兑换券场景下必传 上传图片尺寸670*335，支持格式：png、jpg、jpeg、bmp，大小不超过2MB 限制: 1.指定可核销商品(available_goods)时必传
        /// </summary>
        [XmlElement("voucher_image")]
        public string VoucherImage { get; set; }
    }
}
