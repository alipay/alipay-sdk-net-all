using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoEventreportEventoverviewQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoEventreportEventoverviewQueryResponse : AopResponse
    {
        /// <summary>
        /// 自定义事件报表的数据返回结果
        /// </summary>
        [XmlElement("result")]
        public OpenApiEventReportDataResult Result { get; set; }
    }
}
