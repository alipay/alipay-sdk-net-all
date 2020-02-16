using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenifitGoodsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BenifitGoodsInfo : AopObject
    {
        /// <summary>
        /// 扩展信息，预留字段，非必录项
        /// </summary>
        [XmlElement("extend")]
        public string Extend { get; set; }

        /// <summary>
        /// ISV对应的商品id
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// ISV对应的商品标题
        /// </summary>
        [XmlElement("goods_title")]
        public string GoodsTitle { get; set; }

        /// <summary>
        /// ISV对应的商品类型
        /// </summary>
        [XmlElement("goods_type")]
        public string GoodsType { get; set; }
    }
}
