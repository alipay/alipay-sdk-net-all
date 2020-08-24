using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppAppcontentItemModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppAppcontentItemModifyModel : AopObject
    {
        /// <summary>
        /// 商品条码
        /// </summary>
        [XmlElement("barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// 商品条码类型
        /// </summary>
        [XmlElement("barcode_type")]
        public string BarcodeType { get; set; }

        /// <summary>
        /// 商品扩展信息；请参见产品文档
        /// </summary>
        [XmlArray("biz_extends")]
        [XmlArrayItem("item_ext")]
        public List<ItemExt> BizExtends { get; set; }

        /// <summary>
        /// 业务唯一ID；商品ID为空则为更新主键，商品ID不为空则为更新项；填写后不可变更
        /// </summary>
        [XmlElement("biz_unique_id")]
        public string BizUniqueId { get; set; }

        /// <summary>
        /// 后台叶子类目ID；平台分配
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 商品自定义属性
        /// </summary>
        [XmlElement("custom_properties")]
        public ItemProperty CustomProperties { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 商品详情图地址；最多3张
        /// </summary>
        [XmlArray("detail_pic_paths")]
        [XmlArrayItem("string")]
        public List<string> DetailPicPaths { get; set; }

        /// <summary>
        /// 商品详情地址；目前只支持传一个支付宝小程序地址
        /// </summary>
        [XmlArray("detail_urls")]
        [XmlArrayItem("item_url")]
        public List<ItemUrl> DetailUrls { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品主图地址
        /// </summary>
        [XmlElement("major_pic_path")]
        public string MajorPicPath { get; set; }

        /// <summary>
        /// 商品原价；单位:分
        /// </summary>
        [XmlElement("origin_price")]
        public long OriginPrice { get; set; }

        /// <summary>
        /// 商品售价；单位:分
        /// </summary>
        [XmlElement("sale_price")]
        public long SalePrice { get; set; }

        /// <summary>
        /// 商品状态；可选值：VALID（上架）、INVALID（下架）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 库存状态；可选值：SOLD_OUT（售罄）、AVAILABLE（可售）；非空情况status为INVALID时必须为AVAILABLE；传空情况默认为AVAILABLE
        /// </summary>
        [XmlElement("stock_status")]
        public string StockStatus { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
