using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoEventreportEventoverviewQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoEventreportEventoverviewQueryModel : AopObject
    {
        /// <summary>
        /// 自定义事件报表的查询请求参数
        /// </summary>
        [XmlElement("event_request")]
        public OpenApiEventReportCommRequest EventRequest { get; set; }
    }
}
