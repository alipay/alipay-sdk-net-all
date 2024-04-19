using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceBusinessReportQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceBusinessReportQueryModel : AopObject
    {
        /// <summary>
        /// 商圈内品牌排行榜的行业筛选条件; 填写请参考文档： <a href="https://opendocs.alipay.com/pre-open/0bjxu7">行业信息</a>
        /// </summary>
        [XmlArray("brand_rank_industry_dto")]
        [XmlArrayItem("business_industry_d_t_o")]
        public List<BusinessIndustryDTO> BrandRankIndustryDto { get; set; }

        /// <summary>
        /// 需要查询的商圈概况的指标的集合
        /// </summary>
        [XmlArray("metric_keys")]
        [XmlArrayItem("string")]
        public List<string> MetricKeys { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 需要查询的商圈内画像的元素
        /// </summary>
        [XmlElement("portrait_in_mall_dto")]
        public PortraitInMallReqDTO PortraitInMallDto { get; set; }

        /// <summary>
        /// task_id即商圈分析任务创建后生成的任务的唯一标识
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
