using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeProductCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeProductCreateModel : AopObject
    {
        /// <summary>
        /// 商品描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 图片地址，支持传入不超过5个地址
        /// </summary>
        [XmlElement("images")]
        public string Images { get; set; }

        /// <summary>
        /// 营销信息，支持传入不超过5个营销信息
        /// </summary>
        [XmlElement("marketing_features")]
        public string MarketingFeatures { get; set; }

        /// <summary>
        /// 商户需要保存在商品模型中的元数据
        /// </summary>
        [XmlElement("metadata")]
        public string Metadata { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 单位别名
        /// </summary>
        [XmlElement("unit_label")]
        public string UnitLabel { get; set; }

        /// <summary>
        /// 可用于跳转商户网址地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
