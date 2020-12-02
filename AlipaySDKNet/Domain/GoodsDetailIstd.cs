using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GoodsDetailIstd Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsDetailIstd : AopObject
    {
        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商品单价
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品单位
        /// </summary>
        [XmlElement("unit")]
        public string Unit { get; set; }
    }
}
