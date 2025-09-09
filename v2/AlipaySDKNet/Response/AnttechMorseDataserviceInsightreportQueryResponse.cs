using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechMorseDataserviceInsightreportQueryResponse.
    /// </summary>
    public class AnttechMorseDataserviceInsightreportQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务唯一标识，标识本次查询的唯一识别号，用于链路问题定位排查和对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 品牌信息
        /// </summary>
        [XmlArray("brands")]
        [XmlArrayItem("insight_brand_item")]
        public List<InsightBrandItem> Brands { get; set; }

        /// <summary>
        /// 居住人口洞察年龄
        /// </summary>
        [XmlArray("home_base_age_dist")]
        [XmlArrayItem("insight_dist_item")]
        public List<InsightDistItem> HomeBaseAgeDist { get; set; }

        /// <summary>
        /// 居住人口洞察职业
        /// </summary>
        [XmlArray("home_base_occupation_dist")]
        [XmlArrayItem("insight_dist_item")]
        public List<InsightDistItem> HomeBaseOccupationDist { get; set; }

        /// <summary>
        /// 居住人口洞察性别
        /// </summary>
        [XmlArray("home_base_sex_dist")]
        [XmlArrayItem("insight_dist_item")]
        public List<InsightDistItem> HomeBaseSexDist { get; set; }

        /// <summary>
        /// 居住人口洞察消费水平分布
        /// </summary>
        [XmlArray("home_payment_consumption_level_dist")]
        [XmlArrayItem("insight_dist_item")]
        public List<InsightDistItem> HomePaymentConsumptionLevelDist { get; set; }

        /// <summary>
        /// 常驻人口洞察年龄
        /// </summary>
        [XmlArray("permanent_base_age_dist")]
        [XmlArrayItem("insight_dist_item")]
        public List<InsightDistItem> PermanentBaseAgeDist { get; set; }

        /// <summary>
        /// 常驻人口洞察职业
        /// </summary>
        [XmlArray("permanent_base_occupation_dist")]
        [XmlArrayItem("insight_dist_item")]
        public List<InsightDistItem> PermanentBaseOccupationDist { get; set; }

        /// <summary>
        /// 常驻人口洞察性别
        /// </summary>
        [XmlArray("permanent_base_sex_dist")]
        [XmlArrayItem("insight_dist_item")]
        public List<InsightDistItem> PermanentBaseSexDist { get; set; }

        /// <summary>
        /// APP类型偏好
        /// </summary>
        [XmlArray("permanent_media_apptype_dist")]
        [XmlArrayItem("insight_dist_item")]
        public List<InsightDistItem> PermanentMediaApptypeDist { get; set; }

        /// <summary>
        /// 常驻人口洞察消费水平分布
        /// </summary>
        [XmlArray("permanent_payment_consumption_level_dist")]
        [XmlArrayItem("insight_dist_item")]
        public List<InsightDistItem> PermanentPaymentConsumptionLevelDist { get; set; }

        /// <summary>
        /// 餐饮偏好top50
        /// </summary>
        [XmlArray("permanent_payment_food_poitype_dist")]
        [XmlArrayItem("insight_dist_item")]
        public List<InsightDistItem> PermanentPaymentFoodPoitypeDist { get; set; }

        /// <summary>
        /// 居住人口
        /// </summary>
        [XmlElement("uv_home")]
        public string UvHome { get; set; }

        /// <summary>
        /// 常驻人口
        /// </summary>
        [XmlElement("uv_permanent")]
        public string UvPermanent { get; set; }

        /// <summary>
        /// 工作日月均天级客流
        /// </summary>
        [XmlElement("uv_weekday_day")]
        public string UvWeekdayDay { get; set; }

        /// <summary>
        /// 节假日月均天级客流
        /// </summary>
        [XmlElement("uv_weekend_day")]
        public string UvWeekendDay { get; set; }

        /// <summary>
        /// 工作人口
        /// </summary>
        [XmlElement("uv_work")]
        public string UvWork { get; set; }

        /// <summary>
        /// 工作人口洞察年龄
        /// </summary>
        [XmlArray("work_base_age_dist")]
        [XmlArrayItem("insight_dist_item")]
        public List<InsightDistItem> WorkBaseAgeDist { get; set; }

        /// <summary>
        /// 工作人口洞察职业
        /// </summary>
        [XmlArray("work_base_occupation_dist")]
        [XmlArrayItem("insight_dist_item")]
        public List<InsightDistItem> WorkBaseOccupationDist { get; set; }

        /// <summary>
        /// 工作人口洞察性别
        /// </summary>
        [XmlArray("work_base_sex_dist")]
        [XmlArrayItem("insight_dist_item")]
        public List<InsightDistItem> WorkBaseSexDist { get; set; }

        /// <summary>
        /// 工作人口洞察消费水平分布
        /// </summary>
        [XmlArray("work_payment_consumption_level_dist")]
        [XmlArrayItem("insight_dist_item")]
        public List<InsightDistItem> WorkPaymentConsumptionLevelDist { get; set; }
    }
}
