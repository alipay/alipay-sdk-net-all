using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppItemCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppItemCreateModel : AopObject
    {
        /// <summary>
        /// 商品售卖属性
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
        /// 商品描述详情
        /// </summary>
        [XmlElement("desc_info")]
        public ItemDescInfoVO DescInfo { get; set; }

        /// <summary>
        /// 商品直接购买链接地址
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
        /// 商品原价，分为单位。若填写了skus[]数组，此字段不用填写。
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 商家侧商品ID，要求 APPID 下全局唯一。
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 商品详情页URL
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
        /// sku数组，sku数量上限为25
        /// </summary>
        [XmlArray("skus")]
        [XmlArrayItem("item_sku_create_v_o")]
        public List<ItemSkuCreateVO> Skus { get; set; }

        /// <summary>
        /// 若填写了skus[]数组，此字段不用填写。 若未填写skus[]数组，此字段选填。
        /// </summary>
        [XmlElement("stock_num")]
        public long StockNum { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
