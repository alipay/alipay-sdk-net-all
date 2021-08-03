using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OverseasGoods Data Structure.
    /// </summary>
    [Serializable]
    public class OverseasGoods : AopObject
    {
        /// <summary>
        /// 商品价格，单位为元
        /// </summary>
        [XmlElement("goods_amount")]
        public string GoodsAmount { get; set; }

        /// <summary>
        /// 商品的编号
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }
    }
}
