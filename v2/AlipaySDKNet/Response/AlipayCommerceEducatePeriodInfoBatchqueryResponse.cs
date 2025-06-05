using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducatePeriodInfoBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceEducatePeriodInfoBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 课时列表
        /// </summary>
        [XmlArray("period_list")]
        [XmlArrayItem("edu_period_info")]
        public List<EduPeriodInfo> PeriodList { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }
    }
}
