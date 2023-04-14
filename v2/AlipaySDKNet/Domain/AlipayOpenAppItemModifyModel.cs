using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppItemModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppItemModifyModel : AopObject
    {
        /// <summary>
        /// 商品参数，部分类目有平台定义的类目属性
        /// </summary>
        [XmlArray("attrs")]
        [XmlArrayItem("app_item_attr_v_o")]
        public List<AppItemAttrVO> Attrs { get; set; }

        /// <summary>
        /// 条形码
        /// </summary>
        [XmlElement("barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// 平台类目，填写的类目必须在类目表列出，多级类目只填最后一级。商品类目 ID 及信息可通过<a href="https://opendocs.alipay.com/b/07847b">商品类目表</a>获取。
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 导购描述，用于介绍商品卖点
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 商品详情信息
        /// </summary>
        [XmlElement("desc_info")]
        public ItemDescInfoVO DescInfo { get; set; }

        /// <summary>
        /// 商品立即购买链接地址
        /// </summary>
        [XmlElement("direct_path")]
        public string DirectPath { get; set; }

        /// <summary>
        /// 商品主图的文件id，图片宽度及宽高比，建议值：图片宽度必须大于 750px，宽高比建议 4:3 - 1:1 之间。文件id通过alipay.open.file.upload上传资源获取
        /// </summary>
        [XmlElement("head_img")]
        public string HeadImg { get; set; }

        /// <summary>
        /// 详情图的文件id列表，不超过 3 个图片，图片宽度及宽高比，建议值：图片宽度必须大于 750px，宽高比建议 4:3 - 1:1 之间。文件id通过alipay.open.file.upload上传资源获取
        /// </summary>
        [XmlArray("image_list")]
        [XmlArrayItem("string")]
        public List<string> ImageList { get; set; }

        /// <summary>
        /// 支付宝平台侧商品ID，是支付宝平台侧商品的唯一标识，后续与平台交互，需要使用该 ID，建议持久化。
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品原价，分为单位。若填写了skus[]数组，此字段不用填写。若未填写skus[]数组，此字段必填。
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 商家侧商品ID，要求 APPID 下全局唯一。
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 商品详情页地址
        /// </summary>
        [XmlElement("path")]
        public string Path { get; set; }

        /// <summary>
        /// 价格单元
        /// </summary>
        [XmlElement("price_unit")]
        public string PriceUnit { get; set; }

        /// <summary>
        /// 商品售价，分为单位。若填写了skus[]数组，此字段不用填写。若未填写skus[]数组，此字段必填。
        /// </summary>
        [XmlElement("sale_price")]
        public long SalePrice { get; set; }

        /// <summary>
        /// 商品的售卖状态，包含以下两种状态 已下架(DELISTING) 可售卖(AVAILABLE) 若填写了skus[]数组，此字段不用填写。 若未填写skus[]数组，此字段必填。
        /// </summary>
        [XmlElement("sale_status")]
        public string SaleStatus { get; set; }

        /// <summary>
        /// sku数组
        /// </summary>
        [XmlArray("skus")]
        [XmlArrayItem("item_sku_v_o")]
        public List<ItemSkuVO> Skus { get; set; }

        /// <summary>
        /// 若填写了skus[]数组，此字段不用填写。 若未填写skus[]数组，此字段选填。
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
