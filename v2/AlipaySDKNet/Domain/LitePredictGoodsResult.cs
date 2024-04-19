using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LitePredictGoodsResult Data Structure.
    /// </summary>
    [Serializable]
    public class LitePredictGoodsResult : AopObject
    {
        /// <summary>
        /// 可信度
        /// </summary>
        [XmlElement("conf")]
        public string Conf { get; set; }

        /// <summary>
        /// 商品算法id
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }
    }
}
