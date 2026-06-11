using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SelfShopGroupShopDetail Data Structure.
    /// </summary>
    [Serializable]
    public class SelfShopGroupShopDetail : AopObject
    {
        /// <summary>
        /// 门店位置的具体地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 品牌
        /// </summary>
        [XmlElement("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// 门店的营业时间范围
        /// </summary>
        [XmlElement("business_duration")]
        public string BusinessDuration { get; set; }

        /// <summary>
        /// 门店位置所属的城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 门店位置所属的区县
        /// </summary>
        [XmlElement("district")]
        public string District { get; set; }

        /// <summary>
        /// 门店记录的创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 行业信息详情
        /// </summary>
        [XmlElement("industry_info")]
        public SelfIndustryInfo IndustryInfo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("label_list")]
        [XmlArrayItem("string")]
        public List<string> LabelList { get; set; }

        /// <summary>
        /// 门店位置的纬度信息
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 门店位置的经度信息
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 门店的联系电话
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 门店位置所属的省份
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 企业码门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }
    }
}
