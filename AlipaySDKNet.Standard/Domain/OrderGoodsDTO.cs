using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderGoodsDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OrderGoodsDTO : AopObject
    {
        /// <summary>
        /// 商品数量(FSC的情况下，必填)
        /// </summary>
        [XmlElement("goods_amount")]
        public long GoodsAmount { get; set; }

        /// <summary>
        /// 商品有效时长，单位:天 (临期商品时，必填)
        /// </summary>
        [XmlElement("goods_effective_duration")]
        public long GoodsEffectiveDuration { get; set; }

        /// <summary>
        /// 商品编码(最好69码)
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品生产时间 (临期商品时，必填)
        /// </summary>
        [XmlElement("goods_prd_time")]
        public string GoodsPrdTime { get; set; }

        /// <summary>
        /// 行号, 支持购买几件同一个商品(批次)
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
