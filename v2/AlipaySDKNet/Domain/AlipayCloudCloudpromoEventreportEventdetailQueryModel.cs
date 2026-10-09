using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoEventreportEventdetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoEventreportEventdetailQueryModel : AopObject
    {
        /// <summary>
        /// 生意参谋(增长分析)-自助分析的自定义报表模块请求参数
        /// </summary>
        [XmlElement("event_request")]
        public OpenApiEventReportCommRequest EventRequest { get; set; }
    }
}
