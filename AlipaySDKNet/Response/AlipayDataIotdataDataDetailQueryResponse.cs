using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataIotdataDataDetailQueryResponse.
    /// </summary>
    public class AlipayDataIotdataDataDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 感知数据列表
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("summary_data")]
        public List<SummaryData> Data { get; set; }
    }
}
