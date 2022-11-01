using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContrastResult Data Structure.
    /// </summary>
    [Serializable]
    public class ContrastResult : AopObject
    {
        /// <summary>
        /// 变化商品数量
        /// </summary>
        [XmlElement("goods_count")]
        public long GoodsCount { get; set; }

        /// <summary>
        /// 货柜商品算法ID
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品是否减少，true为减少
        /// </summary>
        [XmlElement("goods_reduce")]
        public bool GoodsReduce { get; set; }
    }
}
