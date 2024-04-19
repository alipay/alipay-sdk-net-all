using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommodityInfoList Data Structure.
    /// </summary>
    [Serializable]
    public class CommodityInfoList : AopObject
    {
        /// <summary>
        /// 品类生效地区码
        /// </summary>
        [XmlElement("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 基础面额，单位为分
        /// </summary>
        [XmlElement("basic_amount")]
        public string BasicAmount { get; set; }

        /// <summary>
        /// 特殊面额（一般为权益金）
        /// </summary>
        [XmlElement("benefit_amout")]
        public string BenefitAmout { get; set; }

        /// <summary>
        /// 品类类目枚举，平台映射
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("commodity_name")]
        public string CommodityName { get; set; }

        /// <summary>
        /// 品类型（储值方案、商品、权益方案）由平台分配
        /// </summary>
        [XmlElement("commodity_type")]
        public string CommodityType { get; set; }

        /// <summary>
        /// 关联用户数量
        /// </summary>
        [XmlElement("customer_amount")]
        public string CustomerAmount { get; set; }

        /// <summary>
        /// 商品跳转链接
        /// </summary>
        [XmlElement("directing_url")]
        public string DirectingUrl { get; set; }

        /// <summary>
        /// 展示图片地址
        /// </summary>
        [XmlElement("display_img_url")]
        public string DisplayImgUrl { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [XmlElement("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// 失效时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        [XmlElement("inventory")]
        public string Inventory { get; set; }

        /// <summary>
        /// 月销量
        /// </summary>
        [XmlElement("monthly_sale")]
        public string MonthlySale { get; set; }

        /// <summary>
        /// 外部资源品类的id（长度<128）
        /// </summary>
        [XmlElement("out_commodity_id")]
        public string OutCommodityId { get; set; }

        /// <summary>
        /// 生效日期（Date类型）
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// A、U，生效、失效状态，为枚举值
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 品类二级类目枚举，平台映射
        /// </summary>
        [XmlElement("sub_category")]
        public string SubCategory { get; set; }

        /// <summary>
        /// 标签列表，需要映射到平台的标签，否则无法处理，联系平台添加
        /// </summary>
        [XmlArray("tags")]
        [XmlArrayItem("string")]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 总销量
        /// </summary>
        [XmlElement("total_sale")]
        public string TotalSale { get; set; }
    }
}
