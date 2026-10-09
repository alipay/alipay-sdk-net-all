using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EntityBasicInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EntityBasicInfo : AopObject
    {
        /// <summary>
        /// (不带省市区)xx路xx地方xx号 或建筑物地址如:xx印象城/杭州萧山国际机场
        /// </summary>
        [XmlElement("address_desc")]
        public string AddressDesc { get; set; }

        /// <summary>
        /// 芝麻借还规定的类目Code，充电宝固定传power_bank
        /// </summary>
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// city
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 电话-座机或手机
        /// </summary>
        [XmlElement("contact_number")]
        public string ContactNumber { get; set; }

        /// <summary>
        /// 点位code
        /// </summary>
        [XmlElement("entity_code")]
        public string EntityCode { get; set; }

        /// <summary>
        /// 实体名称，借用实体的描述，如XX雨伞，XX充电宝，XX自行车
        /// </summary>
        [XmlElement("entity_name")]
        public string EntityName { get; set; }

        /// <summary>
        /// latitude
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// longitude
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// xx:xx-xx:xx, 00:00-23:59
        /// </summary>
        [XmlElement("office_hours_desc")]
        public string OfficeHoursDesc { get; set; }

        /// <summary>
        /// [1,2,3,4,5,6,7]  表示周一到周日  [1,3,5] 表示周一,周三,周五
        /// </summary>
        [XmlArray("open_day")]
        [XmlArrayItem("string")]
        public List<string> OpenDay { get; set; }

        /// <summary>
        /// province
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 免费时长 x (分钟) 不免费就返回null
        /// </summary>
        [XmlElement("rent_free_time")]
        public string RentFreeTime { get; set; }

        /// <summary>
        /// 封顶价格 x (元/天) 没有封顶价格就返回null
        /// </summary>
        [XmlElement("rent_max_price")]
        public string RentMaxPrice { get; set; }

        /// <summary>
        /// 租金信息描述的一部分,租金信息完整描述格式为: X元/YZ，其中X是 rent_price(单价)，Y是rent_price_unit_cnt(租金单位个数)，Z是rent_price_unit(租金单位)，比如2元/30分钟，X是2，Y是30，Z是分钟
        /// </summary>
        [XmlElement("rent_price")]
        public string RentPrice { get; set; }

        /// <summary>
        /// 租金信息描述的一部分,租金信息完整描述格式为: X元/YZ，其中X是 rent_price(单价)，Y是rent_price_unit_cnt(租金单位个数)，Z是rent_price_unit(租金单位)，比如2元/30分钟，X是2，Y是30，Z是分钟 目前本字段支持的枚举为：HOUR/MINUTE
        /// </summary>
        [XmlElement("rent_price_unit")]
        public string RentPriceUnit { get; set; }

        /// <summary>
        /// 租金信息描述的一部分,租金信息完整描述格式为: X元/YZ，其中X是 rent_price(单价)，Y是rent_price_unit_cnt(租金单位个数)，Z是rent_price_unit(租金单位)，比如2元/30分钟，X是2，Y是30，Z是分钟
        /// </summary>
        [XmlElement("rent_price_unit_cnt")]
        public string RentPriceUnitCnt { get; set; }

        /// <summary>
        /// 区
        /// </summary>
        [XmlElement("suburb")]
        public string Suburb { get; set; }
    }
}
