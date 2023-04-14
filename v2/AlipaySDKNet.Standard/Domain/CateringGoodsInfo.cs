using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CateringGoodsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CateringGoodsInfo : AopObject
    {
        /// <summary>
        /// 商品扩展字段，商品信息扩展，key：good_ classification，value：drink
        /// </summary>
        [XmlArray("goods_extra_info")]
        [XmlArrayItem("extra_info")]
        public List<ExtraInfo> GoodsExtraInfo { get; set; }

        /// <summary>
        /// 商品列表信息
        /// </summary>
        [XmlArray("goods_list")]
        [XmlArrayItem("goods")]
        public List<Goods> GoodsList { get; set; }
    }
}
