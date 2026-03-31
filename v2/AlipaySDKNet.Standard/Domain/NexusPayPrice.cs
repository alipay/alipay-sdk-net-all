using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NexusPayPrice Data Structure.
    /// </summary>
    [Serializable]
    public class NexusPayPrice : AopObject
    {
        /// <summary>
        /// 是否可用
        /// </summary>
        [XmlElement("active")]
        public bool Active { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 价格id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 价格信息元数据，通过价格创建接口传入
        /// </summary>
        [XmlElement("metadata")]
        public string Metadata { get; set; }

        /// <summary>
        /// 价格归属的商品模型信息
        /// </summary>
        [XmlElement("product")]
        public NexusPayProduct Product { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 仅当type=recurring时必选
        /// </summary>
        [XmlElement("recurring")]
        public Recurring Recurring { get; set; }

        /// <summary>
        /// 价格类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 单位金额，单位：分
        /// </summary>
        [XmlElement("unit_amount")]
        public long UnitAmount { get; set; }
    }
}
