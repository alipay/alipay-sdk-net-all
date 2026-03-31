using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NexusPayProduct Data Structure.
    /// </summary>
    [Serializable]
    public class NexusPayProduct : AopObject
    {
        /// <summary>
        /// 是否可用
        /// </summary>
        [XmlElement("active")]
        public bool Active { get; set; }

        /// <summary>
        /// 默认价格信息
        /// </summary>
        [XmlElement("default_price")]
        public NexusSimplePrice DefaultPrice { get; set; }

        /// <summary>
        /// 商品的默认价格id
        /// </summary>
        [XmlElement("default_price_id")]
        public string DefaultPriceId { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 商品信息元数据，通过商品创建接口传入
        /// </summary>
        [XmlElement("metadata")]
        public string Metadata { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
