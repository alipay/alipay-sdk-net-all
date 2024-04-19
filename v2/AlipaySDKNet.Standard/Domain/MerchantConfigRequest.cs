using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantConfigRequest Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantConfigRequest : AopObject
    {
        /// <summary>
        /// 详情页banner跳转目标小程序appid
        /// </summary>
        [XmlElement("banner_app_id")]
        public string BannerAppId { get; set; }

        /// <summary>
        /// 详情页banner图片url
        /// </summary>
        [XmlElement("banner_image_url")]
        public string BannerImageUrl { get; set; }

        /// <summary>
        /// 详情页banner跳转所需参数
        /// </summary>
        [XmlElement("banner_page")]
        public string BannerPage { get; set; }

        /// <summary>
        /// 详情页banner跳转地址
        /// </summary>
        [XmlElement("banner_web_url")]
        public string BannerWebUrl { get; set; }

        /// <summary>
        /// 目标小程序appid
        /// </summary>
        [XmlElement("jump_app_id")]
        public string JumpAppId { get; set; }

        /// <summary>
        /// 跳转所需参数
        /// </summary>
        [XmlElement("jump_page")]
        public string JumpPage { get; set; }

        /// <summary>
        /// 跳转地址
        /// </summary>
        [XmlElement("jump_web_url")]
        public string JumpWebUrl { get; set; }

        /// <summary>
        /// 商家联系方式
        /// </summary>
        [XmlElement("merchant_contact")]
        public string MerchantContact { get; set; }

        /// <summary>
        /// 签署平台为商家分配的应用Id
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商家logo
        /// </summary>
        [XmlElement("merchant_logo")]
        public string MerchantLogo { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }
    }
}
