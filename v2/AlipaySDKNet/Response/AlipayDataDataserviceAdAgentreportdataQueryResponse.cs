using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdAgentreportdataQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdAgentreportdataQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询结果数据列表，当无投放未产生展现消数据时，查询数据为空
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("ad_report_data_detail")]
        public List<AdReportDataDetail> DataList { get; set; }

        /// <summary>
        /// 分页查询的记录总条数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
