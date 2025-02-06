using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CrossBorderEcomCompanyDetail Data Structure.
    /// </summary>
    [Serializable]
    public class CrossBorderEcomCompanyDetail : AopObject
    {
        /// <summary>
        /// 近1年内活跃月（单位：个月）
        /// </summary>
        [XmlElement("active_month_past_year")]
        public string ActiveMonthPastYear { get; set; }

        /// <summary>
        /// 活跃店铺数（单位：个）
        /// </summary>
        [XmlElement("active_shop_num")]
        public string ActiveShopNum { get; set; }

        /// <summary>
        /// 所有销售类目明细
        /// </summary>
        [XmlArray("business_list")]
        [XmlArrayItem("string")]
        public List<string> BusinessList { get; set; }

        /// <summary>
        /// 已关店店铺数（单位：个）
        /// </summary>
        [XmlElement("closed_shop_num")]
        public string ClosedShopNum { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("ent_name")]
        public string EntName { get; set; }

        /// <summary>
        /// 企业状态
        /// </summary>
        [XmlElement("ent_status")]
        public string EntStatus { get; set; }

        /// <summary>
        /// 企业类型
        /// </summary>
        [XmlElement("ent_type")]
        public string EntType { get; set; }

        /// <summary>
        /// 该企业下，所有店铺中，最长营业时长(年)的店铺的营业时长
        /// </summary>
        [XmlElement("max_shop_operation_years")]
        public string MaxShopOperationYears { get; set; }

        /// <summary>
        /// 已下架商品个数（单位：个）
        /// </summary>
        [XmlElement("off_shelf_num")]
        public string OffShelfNum { get; set; }

        /// <summary>
        /// 在售商品个数（单位：个）
        /// </summary>
        [XmlElement("on_sale_item_num")]
        public string OnSaleItemNum { get; set; }

        /// <summary>
        /// 在营店铺数（单位：个）
        /// </summary>
        [XmlElement("operation_shop_num")]
        public string OperationShopNum { get; set; }

        /// <summary>
        /// 法定代表人
        /// </summary>
        [XmlElement("person_name")]
        public string PersonName { get; set; }

        /// <summary>
        /// 入住平台明细
        /// </summary>
        [XmlArray("platform_list")]
        [XmlArrayItem("string")]
        public List<string> PlatformList { get; set; }

        /// <summary>
        /// 入驻平台总数（个）
        /// </summary>
        [XmlElement("platform_num")]
        public string PlatformNum { get; set; }

        /// <summary>
        /// 1年内入住平台数（个）
        /// </summary>
        [XmlElement("platform_past_year")]
        public string PlatformPastYear { get; set; }

        /// <summary>
        /// 企业注册地市
        /// </summary>
        [XmlElement("reg_city")]
        public string RegCity { get; set; }

        /// <summary>
        /// 企业注册地区县
        /// </summary>
        [XmlElement("reg_county")]
        public string RegCounty { get; set; }

        /// <summary>
        /// 成立时长（单位：年）
        /// </summary>
        [XmlElement("reg_duration")]
        public string RegDuration { get; set; }

        /// <summary>
        /// 注册号
        /// </summary>
        [XmlElement("reg_no")]
        public string RegNo { get; set; }

        /// <summary>
        /// 企业注册地省
        /// </summary>
        [XmlElement("reg_province")]
        public string RegProvince { get; set; }

        /// <summary>
        /// 提供近24个月的销售明细数据
        /// </summary>
        [XmlArray("sale_details")]
        [XmlArrayItem("sale_info")]
        public List<SaleInfo> SaleDetails { get; set; }

        /// <summary>
        /// 销往的国家明细
        /// </summary>
        [XmlArray("sell_country_list")]
        [XmlArrayItem("string")]
        public List<string> SellCountryList { get; set; }

        /// <summary>
        /// 有动销的商品个数（单位：个）
        /// </summary>
        [XmlElement("sell_out_item_num")]
        public string SellOutItemNum { get; set; }

        /// <summary>
        /// 近1年内开店数（单位：个）
        /// </summary>
        [XmlElement("shop_num_past_year")]
        public string ShopNumPastYear { get; set; }

        /// <summary>
        /// 旗下店铺好评率明细
        /// </summary>
        [XmlArray("shop_positive_rating_list")]
        [XmlArrayItem("string")]
        public List<string> ShopPositiveRatingList { get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [XmlElement("uscc")]
        public string Uscc { get; set; }
    }
}
