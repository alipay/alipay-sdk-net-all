using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommonVoucherDisplayInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CommonVoucherDisplayInfo : AopObject
    {
        /// <summary>
        /// 商家品牌 logo 链接。
        /// </summary>
        [XmlElement("brand_logo")]
        public string BrandLogo { get; set; }

        /// <summary>
        /// 商户品牌名称。 如果不设置品牌名称，则默认使用支付宝商家系统中维护的商家别名。 如果没有维护商家别名，则使用默认名称： 商家优惠。 用户领取优惠券后，品牌名称会对用户进行展示
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 用于说明详细的活动规则，会展示在支付宝卡包券详情页。
        /// </summary>
        [XmlElement("voucher_description")]
        public string VoucherDescription { get; set; }

        /// <summary>
        /// 券详情图片链接。
        /// </summary>
        [XmlArray("voucher_detail_images")]
        [XmlArrayItem("string")]
        public List<string> VoucherDetailImages { get; set; }

        /// <summary>
        /// 券封面图链接。
        /// </summary>
        [XmlElement("voucher_image")]
        public string VoucherImage { get; set; }
    }
}
