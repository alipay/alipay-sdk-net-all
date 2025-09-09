using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CrossBorderEcomShopDetail Data Structure.
    /// </summary>
    [Serializable]
    public class CrossBorderEcomShopDetail : AopObject
    {
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
        /// 平台ID
        /// </summary>
        [XmlElement("platform_id")]
        public string PlatformId { get; set; }

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
        /// 销往的国家
        /// </summary>
        [XmlArray("sell_country_list")]
        [XmlArrayItem("string")]
        public List<string> SellCountryList { get; set; }

        /// <summary>
        /// 有动销的商品个数
        /// </summary>
        [XmlElement("sell_out_item_num")]
        public string SellOutItemNum { get; set; }

        /// <summary>
        /// 店铺企业所在市
        /// </summary>
        [XmlElement("shop_corp_city")]
        public string ShopCorpCity { get; set; }

        /// <summary>
        /// 店铺企业所在区
        /// </summary>
        [XmlElement("shop_corp_county")]
        public string ShopCorpCounty { get; set; }

        /// <summary>
        /// 店铺企业所在省
        /// </summary>
        [XmlElement("shop_corp_province")]
        public string ShopCorpProvince { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺开店时长(年)(未满1年则为0)
        /// </summary>
        [XmlElement("shop_open_years")]
        public string ShopOpenYears { get; set; }

        /// <summary>
        /// 店铺好评率
        /// </summary>
        [XmlArray("shop_positive_rating_list")]
        [XmlArrayItem("string")]
        public List<string> ShopPositiveRatingList { get; set; }

        /// <summary>
        /// 店铺状态
        /// </summary>
        [XmlElement("shop_status")]
        public string ShopStatus { get; set; }

        /// <summary>
        /// 店铺类型
        /// </summary>
        [XmlElement("shop_type")]
        public string ShopType { get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [XmlElement("uscc")]
        public string Uscc { get; set; }
    }
}
