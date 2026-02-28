using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInsitutionServicePreviewResponse.
    /// </summary>
    public class AlipayCommerceMedicalInsitutionServicePreviewResponse : AopResponse
    {
        /// <summary>
        /// 医疗全局指标
        /// </summary>
        [XmlElement("medical_overall_metric")]
        public MedicalOverallMetric MedicalOverallMetric { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("org_service_metric_list")]
        [XmlArrayItem("org_service_metric")]
        public List<OrgServiceMetric> OrgServiceMetricList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("service_trend_metric_list")]
        [XmlArrayItem("service_trends_metric")]
        public List<ServiceTrendsMetric> ServiceTrendMetricList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("service_used_metric_list")]
        [XmlArrayItem("service_used_metric")]
        public List<ServiceUsedMetric> ServiceUsedMetricList { get; set; }
    }
}
