using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaoBaoEcomStoreInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TaoBaoEcomStoreInfo : AopObject
    {
        /// <summary>
        /// 关联主播明细：SHA256加密
        /// </summary>
        [XmlElement("anchor_list")]
        public string AnchorList { get; set; }

        /// <summary>
        /// 关联主播数
        /// </summary>
        [XmlElement("anchor_num")]
        public string AnchorNum { get; set; }

        /// <summary>
        /// 店铺发货市
        /// </summary>
        [XmlElement("delivery_city")]
        public string DeliveryCity { get; set; }

        /// <summary>
        /// 店铺发货区
        /// </summary>
        [XmlElement("delivery_county")]
        public string DeliveryCounty { get; set; }

        /// <summary>
        /// 店铺发货省
        /// </summary>
        [XmlElement("delivery_province")]
        public string DeliveryProvince { get; set; }

        /// <summary>
        /// 主营类目
        /// </summary>
        [XmlElement("main_business")]
        public string MainBusiness { get; set; }

        /// <summary>
        /// 已下架商品个数
        /// </summary>
        [XmlElement("off_shelf_num")]
        public string OffShelfNum { get; set; }

        /// <summary>
        /// 在售的品牌明细
        /// </summary>
        [XmlArray("on_sale_brand_list")]
        [XmlArrayItem("string")]
        public List<string> OnSaleBrandList { get; set; }

        /// <summary>
        /// 在售品牌个数
        /// </summary>
        [XmlElement("on_sale_brand_num")]
        public string OnSaleBrandNum { get; set; }

        /// <summary>
        /// 在售商品个数
        /// </summary>
        [XmlElement("on_sale_item_num")]
        public string OnSaleItemNum { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("org_name")]
        public string OrgName { get; set; }

        /// <summary>
        /// 平台规模
        /// </summary>
        [XmlElement("platform_scale")]
        public string PlatformScale { get; set; }

        /// <summary>
        /// 平台类型
        /// </summary>
        [XmlElement("platform_type")]
        public string PlatformType { get; set; }

        /// <summary>
        /// 注册号
        /// </summary>
        [XmlElement("reg_no")]
        public string RegNo { get; set; }

        /// <summary>
        /// 提供近24个月的销售明细数据
        /// </summary>
        [XmlArray("sale_details")]
        [XmlArrayItem("sale_info")]
        public List<SaleInfo> SaleDetails { get; set; }

        /// <summary>
        /// 有动销的商品个数
        /// </summary>
        [XmlElement("sell_out_item_num")]
        public string SellOutItemNum { get; set; }

        /// <summary>
        /// 店铺所在市
        /// </summary>
        [XmlElement("shop_city")]
        public string ShopCity { get; set; }

        /// <summary>
        /// 店铺关店时间
        /// </summary>
        [XmlElement("shop_close_date")]
        public string ShopCloseDate { get; set; }

        /// <summary>
        /// 店铺所在区
        /// </summary>
        [XmlElement("shop_county")]
        public string ShopCounty { get; set; }

        /// <summary>
        /// 店铺ID：SHA256加密
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺名称：SHA256加密后输出
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺开店时间（yyyy-mm-dd）
        /// </summary>
        [XmlElement("shop_open_date")]
        public string ShopOpenDate { get; set; }

        /// <summary>
        /// 店铺所在省
        /// </summary>
        [XmlElement("shop_province")]
        public string ShopProvince { get; set; }

        /// <summary>
        /// 店铺评分明细
        /// </summary>
        [XmlElement("shop_rating")]
        public ShopRatingInfo ShopRating { get; set; }

        /// <summary>
        /// 店铺状态
        /// </summary>
        [XmlElement("shop_status")]
        public string ShopStatus { get; set; }

        /// <summary>
        /// 店铺主类型
        /// </summary>
        [XmlElement("shop_type")]
        public string ShopType { get; set; }

        /// <summary>
        /// 店铺类型
        /// </summary>
        [XmlElement("shop_way")]
        public string ShopWay { get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [XmlElement("uscc")]
        public string Uscc { get; set; }
    }
}
