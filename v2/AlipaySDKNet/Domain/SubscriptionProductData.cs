using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubscriptionProductData Data Structure.
    /// </summary>
    [Serializable]
    public class SubscriptionProductData : AopObject
    {
        /// <summary>
        /// 商品描述，按商户请求原样保存到商品快照
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 商品图片 URL 列表，必须是合法的 JSON string array 字符串，建议不超过 5 个元素
        /// </summary>
        [XmlElement("images")]
        public string Images { get; set; }

        /// <summary>
        /// 商品营销特性列表，必须是合法的 JSON string array 字符串，建议不超过 5 个元素
        /// </summary>
        [XmlElement("marketing_features")]
        public string MarketingFeatures { get; set; }

        /// <summary>
        /// 商品元数据，必须是合法的 JSON object 字符串，且每个 value 必须是字符串
        /// </summary>
        [XmlElement("metadata")]
        public string Metadata { get; set; }

        /// <summary>
        /// 商品名称，不能为空，用于签约页和订阅商品展示
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商品计量单位描述，例如 seat、席位，按商户请求原样保存
        /// </summary>
        [XmlElement("unit_label")]
        public string UnitLabel { get; set; }

        /// <summary>
        /// 商品详情页 URL
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
