using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GoodsPos Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsPos : AopObject
    {
        /// <summary>
        /// 商品Id
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品重力位置信息
        /// </summary>
        [XmlElement("pos")]
        public long Pos { get; set; }
    }
}
