using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceProductAppCreateormodifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceProductAppCreateormodifyModel : AopObject
    {
        /// <summary>
        /// 商品属性列表
        /// </summary>
        [XmlArray("attrs")]
        [XmlArrayItem("item_attr_dto")]
        public List<ItemAttrDto> Attrs { get; set; }

        /// <summary>
        /// 条形码
        /// </summary>
        [XmlElement("barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 商品平台类目信息
        /// </summary>
        [XmlElement("category")]
        public ItemCategoryDto Category { get; set; }

        /// <summary>
        /// 商品详情描述文案
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 商品描述详情
        /// </summary>
        [XmlElement("desc_info")]
        public ItemDescInfoDto DescInfo { get; set; }

        /// <summary>
        /// 商品直接购买链接地址
        /// </summary>
        [XmlElement("direct_path")]
        public string DirectPath { get; set; }

        /// <summary>
        /// 商品类型，由灯火系统分配给商户
        /// </summary>
        [XmlElement("entity_type")]
        public string EntityType { get; set; }

        /// <summary>
        /// 商品主图
        /// </summary>
        [XmlElement("head_img")]
        public string HeadImg { get; set; }

        /// <summary>
        /// 商品子图
        /// </summary>
        [XmlArray("image_list")]
        [XmlArrayItem("string")]
        public List<string> ImageList { get; set; }

        /// <summary>
        /// 商品类型
        /// </summary>
        [XmlElement("item_sub_type")]
        public string ItemSubType { get; set; }

        /// <summary>
        /// 落地页信息
        /// </summary>
        [XmlArray("landing")]
        [XmlArrayItem("landing_type_dto")]
        public List<LandingTypeDto> Landing { get; set; }

        /// <summary>
        /// 商品原价，单位为分（人民币）
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 商品外部id
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 商品来源，由灯火系统分配给商户
        /// </summary>
        [XmlElement("out_source")]
        public string OutSource { get; set; }

        /// <summary>
        /// 商品归属的商户oid, 传入oid时优先使用oid，否则使用pid
        /// </summary>
        [XmlElement("owner_oid")]
        public string OwnerOid { get; set; }

        /// <summary>
        /// 商品归属的商户pid
        /// </summary>
        [XmlElement("owner_pid")]
        public string OwnerPid { get; set; }

        /// <summary>
        /// 商品详情页url
        /// </summary>
        [XmlElement("path")]
        public string Path { get; set; }

        /// <summary>
        /// 价格单元
        /// </summary>
        [XmlElement("price_unit")]
        public string PriceUnit { get; set; }

        /// <summary>
        /// 商家在支付宝数字推广平台唯一标识
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("prod_app_id")]
        public string ProdAppId { get; set; }

        /// <summary>
        /// 商品售价，单位为分
        /// </summary>
        [XmlElement("sale_price")]
        public long SalePrice { get; set; }

        /// <summary>
        /// 商品售卖状态
        /// </summary>
        [XmlElement("sale_status")]
        public string SaleStatus { get; set; }

        /// <summary>
        /// 商品销量信息，realSells为商品真实销量，customerSells为商品用户自填销量，displaySells为商品展示销量
        /// </summary>
        [XmlElement("sells_info")]
        public SellsInfo SellsInfo { get; set; }

        /// <summary>
        /// 商品sku信息
        /// </summary>
        [XmlArray("skus")]
        [XmlArrayItem("item_sku_dto")]
        public List<ItemSkuDto> Skus { get; set; }

        /// <summary>
        /// 商品库存，目前支持库存区间为0-99999999。
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
