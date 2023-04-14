using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WeightFloor Data Structure.
    /// </summary>
    [Serializable]
    public class WeightFloor : AopObject
    {
        /// <summary>
        /// 层号
        /// </summary>
        [XmlElement("floor_id")]
        public string FloorId { get; set; }

        /// <summary>
        /// 重力层商品位置信息列表
        /// </summary>
        [XmlArray("goods_list")]
        [XmlArrayItem("goods_pos")]
        public List<GoodsPos> GoodsList { get; set; }
    }
}
