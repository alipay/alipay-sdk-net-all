using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarRentalGoodsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CarRentalGoodsInfo : AopObject
    {
        /// <summary>
        /// 商品扩展字段
        /// </summary>
        [XmlArray("goods_extra_info")]
        [XmlArrayItem("extra_info")]
        public List<ExtraInfo> GoodsExtraInfo { get; set; }

        /// <summary>
        /// 商品列表信息
        /// </summary>
        [XmlArray("goods_list")]
        [XmlArrayItem("car_rental_goods")]
        public List<CarRentalGoods> GoodsList { get; set; }
    }
}
