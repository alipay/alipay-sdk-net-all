using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemSpuVO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemSpuVO : AopObject
    {
        /// <summary>
        /// 平台类目，填写的类目必须在类目表列出，多级类目只填最后一级。商品类目 ID 及信息可通过商品类目表获取。
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 商品主图链接
        /// </summary>
        [XmlElement("head_img")]
        public string HeadImg { get; set; }

        /// <summary>
        /// 支付宝平台侧商品ID，是支付宝平台侧商品的唯一标识，后续与平台交互，需要使用该 ID，建议持久化。 2023010122000000000001
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商家侧商品ID，要求 APPID 下全局唯一。
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 商品详情页链接
        /// </summary>
        [XmlElement("path")]
        public string Path { get; set; }

        /// <summary>
        /// 商品价格
        /// </summary>
        [XmlElement("price")]
        public ItemPriceVO Price { get; set; }

        /// <summary>
        /// 10 库存 若填写了skus[]数组，此字段不用填写。 若未填写skus[]数组，此字段必填。 目前支持库存区间0~99999
        /// </summary>
        [XmlElement("stock_num")]
        public long StockNum { get; set; }

        /// <summary>
        /// 商品名称，字符类型，最少不低于3，最长不超过60个字。注：1.商品标题只允许汉字、数字、英文字母、特殊字符集；2.商品标题不得仅为数字、字母、特殊字符集或上述三种的组合。
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
