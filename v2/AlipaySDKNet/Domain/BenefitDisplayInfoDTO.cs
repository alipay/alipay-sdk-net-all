using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitDisplayInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitDisplayInfoDTO : AopObject
    {
        /// <summary>
        /// 按钮文案
        /// </summary>
        [XmlElement("action_text")]
        public string ActionText { get; set; }

        /// <summary>
        /// 1、SHOW_PAYMENT_CODE  展示付款码；2、SCAN  前往扫一扫3、CUSTOM  自定义跳转
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 按钮跳转链接地址
        /// </summary>
        [XmlElement("action_url")]
        public string ActionUrl { get; set; }

        /// <summary>
        /// 券详细图列表
        /// </summary>
        [XmlArray("benefit_detail_images")]
        [XmlArrayItem("string")]
        public List<string> BenefitDetailImages { get; set; }

        /// <summary>
        /// 实际传值为权益详情页封面图片在oss中的key
        /// </summary>
        [XmlElement("benefit_image")]
        public string BenefitImage { get; set; }

        /// <summary>
        /// 实际传值为品牌logo图片在oss中的key
        /// </summary>
        [XmlElement("brand_logo")]
        public string BrandLogo { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }
    }
}
