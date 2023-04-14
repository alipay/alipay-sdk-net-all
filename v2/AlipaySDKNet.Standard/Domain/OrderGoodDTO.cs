using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderGoodDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OrderGoodDTO : AopObject
    {
        /// <summary>
        /// 对应订单有环保类型时，能量发放结果
        /// </summary>
        [XmlArray("environmental_list")]
        [XmlArrayItem("environmental_d_t_o")]
        public List<EnvironmentalDTO> EnvironmentalList { get; set; }

        /// <summary>
        /// 商品码，根据之前数据回传的中有环保类型的商品码
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }
    }
}
