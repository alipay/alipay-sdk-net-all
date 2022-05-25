using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PreOrderExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PreOrderExtInfo : AopObject
    {
        /// <summary>
        /// 品牌id
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 请求渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 单据属性,风控系统使用
        /// </summary>
        [XmlElement("order_feature")]
        public string OrderFeature { get; set; }
    }
}
