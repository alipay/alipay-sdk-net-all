using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ToppingInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ToppingInfo : AopObject
    {
        /// <summary>
        /// 加料数量，单位为份
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 加料名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 加料价格
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 加料类型编码，商品列表查询接口中，返回了可选加料列表，该字段取可选加料列表中指定加料类型的code字段值
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
