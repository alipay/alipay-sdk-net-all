using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardLevelConfigDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CardLevelConfigDTO : AopObject
    {
        /// <summary>
        /// background_url：在支付宝卡包展示的背景图片地址，通过alipay.offline.material.image.upload接口上传图片资源获取(https://opendocs.alipay.com/open/02qth8)
        /// </summary>
        [XmlElement("background_url")]
        public string BackgroundUrl { get; set; }

        /// <summary>
        /// banner_image_url：在支付宝卡包展示的banner图片地址，url通过alipay.offline.material.image.upload接口上传图片资源获取(https://opendocs.alipay.com/open/02qth8)
        /// </summary>
        [XmlElement("banner_image_url")]
        public string BannerImageUrl { get; set; }

        /// <summary>
        /// banner_url：用户在支付宝卡包，店家卡banner后的跳转服务地址
        /// </summary>
        [XmlElement("banner_url")]
        public string BannerUrl { get; set; }

        /// <summary>
        /// level：卡等级名称
        /// </summary>
        [XmlElement("level")]
        public string Level { get; set; }

        /// <summary>
        /// logo_url：在支付宝卡包展示的logo地址，通过alipay.offline.material.image.upload接口上传图片资源获取(https://opendocs.alipay.com/open/02qth8)
        /// </summary>
        [XmlElement("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// quick_services：卡的快捷服务，快捷服务数量限制为[1,3]
        /// </summary>
        [XmlArray("quick_services")]
        [XmlArrayItem("card_quick_service_d_t_o")]
        public List<CardQuickServiceDTO> QuickServices { get; set; }

        /// <summary>
        /// sub_title:在支付宝卡包中展示的卡副标题
        /// </summary>
        [XmlElement("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// title:在支付宝卡包中展示的卡名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
