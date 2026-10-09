using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Workload Data Structure.
    /// </summary>
    [Serializable]
    public class Workload : AopObject
    {
        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 岗位编码
        /// </summary>
        [XmlElement("job_code")]
        public string JobCode { get; set; }

        /// <summary>
        /// 岗位名称
        /// </summary>
        [XmlElement("job_name")]
        public string JobName { get; set; }

        /// <summary>
        /// 层级编码
        /// </summary>
        [XmlElement("level_code")]
        public string LevelCode { get; set; }

        /// <summary>
        /// 层级名称
        /// </summary>
        [XmlElement("level_name")]
        public string LevelName { get; set; }

        /// <summary>
        /// 按月专用，月数
        /// </summary>
        [XmlElement("months")]
        public string Months { get; set; }

        /// <summary>
        /// 计件专用，总件数
        /// </summary>
        [XmlElement("packages")]
        public string Packages { get; set; }

        /// <summary>
        /// 工作量（人天）
        /// </summary>
        [XmlElement("person_day")]
        public string PersonDay { get; set; }

        /// <summary>
        /// 按月专用，人数
        /// </summary>
        [XmlElement("persons")]
        public string Persons { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 价格类型
        /// </summary>
        [XmlElement("price_type")]
        public string PriceType { get; set; }

        /// <summary>
        /// 项目编码
        /// </summary>
        [XmlElement("project_code")]
        public string ProjectCode { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 办公地点编码
        /// </summary>
        [XmlElement("site_code")]
        public string SiteCode { get; set; }

        /// <summary>
        /// 地办公点名称
        /// </summary>
        [XmlElement("site_name")]
        public string SiteName { get; set; }

        /// <summary>
        /// 金额合计
        /// </summary>
        [XmlElement("total_price")]
        public string TotalPrice { get; set; }

        /// <summary>
        /// 计件专用，参考工作效率
        /// </summary>
        [XmlElement("work_efficiency")]
        public string WorkEfficiency { get; set; }
    }
}
