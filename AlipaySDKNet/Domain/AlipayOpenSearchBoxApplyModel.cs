using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSearchBoxApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSearchBoxApplyModel : AopObject
    {
        /// <summary>
        /// 品牌介绍，5-15个中文字符
        /// </summary>
        [XmlElement("box_desc")]
        public string BoxDesc { get; set; }

        /// <summary>
        /// 品牌id
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 自定义触发词，可配置1个，限1-8个中文字符
        /// </summary>
        [XmlArray("custom_keywords")]
        [XmlArrayItem("string")]
        public List<string> CustomKeywords { get; set; }

        /// <summary>
        /// 氛围图片id，调用接口alipay.open.file.upload上传图片获取图片id。图片规范：https://opendocs.alipay.com/mini/operation/atmospheredesign
        /// </summary>
        [XmlElement("image_id")]
        public string ImageId { get; set; }

        /// <summary>
        /// 氛围图片名
        /// </summary>
        [XmlElement("image_name")]
        public string ImageName { get; set; }

        /// <summary>
        /// 商户id，代运营模式下传入
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 关联账号信息，1-2个
        /// </summary>
        [XmlArray("related_accounts")]
        [XmlArrayItem("search_box_app_info")]
        public List<SearchBoxAppInfo> RelatedAccounts { get; set; }

        /// <summary>
        /// 服务信息
        /// </summary>
        [XmlArray("service_infos")]
        [XmlArrayItem("search_box_service_info")]
        public List<SearchBoxServiceInfo> ServiceInfos { get; set; }

        /// <summary>
        /// 小程序id，brand_id为空时必传
        /// </summary>
        [XmlElement("target_appid")]
        public string TargetAppid { get; set; }
    }
}
