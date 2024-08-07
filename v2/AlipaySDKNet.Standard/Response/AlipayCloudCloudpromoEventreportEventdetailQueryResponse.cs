using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoEventreportEventdetailQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoEventreportEventdetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 数据结果， 包含响应的参数和响应的具体事件分析数据
        /// </summary>
        [XmlElement("result")]
        public OpenApiEventReportDataResult Result { get; set; }
    }
}
