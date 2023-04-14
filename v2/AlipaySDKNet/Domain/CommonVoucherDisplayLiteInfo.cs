using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommonVoucherDisplayLiteInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CommonVoucherDisplayLiteInfo : AopObject
    {
        /// <summary>
        /// 商户品牌 logo 链接。
        /// </summary>
        [XmlElement("brand_logo")]
        public string BrandLogo { get; set; }

        /// <summary>
        /// 商户品牌名称。 如果不设置品牌名称，则默认使用支付宝商家系统中维护的商家别名。 如果没有维护商家别名，则使用默认名称：商家优惠。 用户领取优惠券后，品牌名称会对用户进行展示。
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }
    }
}
