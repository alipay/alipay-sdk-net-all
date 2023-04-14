using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarRentalGoods Data Structure.
    /// </summary>
    [Serializable]
    public class CarRentalGoods : AopObject
    {
        /// <summary>
        /// 商家车辆id
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("goods_num")]
        public string GoodsNum { get; set; }

        /// <summary>
        /// 商品图片id
        /// </summary>
        [XmlElement("goods_pic_url")]
        public string GoodsPicUrl { get; set; }

        /// <summary>
        /// 商品单价
        /// </summary>
        [XmlElement("goods_price")]
        public string GoodsPrice { get; set; }

        /// <summary>
        /// 商品规格
        /// </summary>
        [XmlElement("goods_specs")]
        public string GoodsSpecs { get; set; }
    }
}
