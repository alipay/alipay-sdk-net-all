using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdPromotepagestatisticQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdPromotepagestatisticQueryResponse : AopResponse
    {
        /// <summary>
        /// 留资统计列表
        /// </summary>
        [XmlArray("collectinfo_list")]
        [XmlArrayItem("promote_page_statistic")]
        public List<PromotePageStatistic> CollectinfoList { get; set; }
    }
}
