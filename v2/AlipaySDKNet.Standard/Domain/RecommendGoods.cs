using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecommendGoods Data Structure.
    /// </summary>
    [Serializable]
    public class RecommendGoods : AopObject
    {
        /// <summary>
        /// 商品barcode
        /// </summary>
        [XmlElement("barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// 行业商品goodsCode
        /// </summary>
        [XmlElement("goods_code")]
        public string GoodsCode { get; set; }

        /// <summary>
        /// 推荐排名
        /// </summary>
        [XmlElement("rank")]
        public string Rank { get; set; }

        /// <summary>
        /// 推荐商品使用货道数
        /// </summary>
        [XmlElement("recommend_channels_count")]
        public string RecommendChannelsCount { get; set; }

        /// <summary>
        /// 推荐商品数量
        /// </summary>
        [XmlElement("recommend_goods_count")]
        public string RecommendGoodsCount { get; set; }

        /// <summary>
        /// 商品推荐理由
        /// </summary>
        [XmlElement("recommend_reason")]
        public string RecommendReason { get; set; }
    }
}
