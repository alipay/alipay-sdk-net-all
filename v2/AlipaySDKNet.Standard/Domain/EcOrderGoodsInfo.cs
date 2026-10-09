using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcOrderGoodsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EcOrderGoodsInfo : AopObject
    {
        /// <summary>
        /// 商品扩展信息
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("ec_order_ext_info")]
        public List<EcOrderExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 订单所包含的商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }
    }
}
