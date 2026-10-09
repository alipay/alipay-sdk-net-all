using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MethodInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MethodInfo : AopObject
    {
        /// <summary>
        /// 商品做法id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 商品做法库存，单位份
        /// </summary>
        [XmlElement("inventory")]
        public long Inventory { get; set; }

        /// <summary>
        /// 商品做法名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商品做法加价，单位元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品做法spuid
        /// </summary>
        [XmlElement("spu_id")]
        public string SpuId { get; set; }
    }
}
