using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdReportmetricQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdReportmetricQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询指标接口时，返回的指标详情列表
        /// </summary>
        [XmlArray("metric_list")]
        [XmlArrayItem("ad_report_metric_detail")]
        public List<AdReportMetricDetail> MetricList { get; set; }

        /// <summary>
        /// 查询的记录总条数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
