using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiEventReportItemVO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiEventReportItemVO : AopObject
    {
        /// <summary>
        /// 业务日期
        /// </summary>
        [XmlElement("dt")]
        public string Dt { get; set; }

        /// <summary>
        /// 事件名称
        /// </summary>
        [XmlElement("event")]
        public string Event { get; set; }

        /// <summary>
        /// 访问人数
        /// </summary>
        [XmlElement("people_count")]
        public long PeopleCount { get; set; }

        /// <summary>
        /// 访问次数
        /// </summary>
        [XmlElement("people_visit_count")]
        public long PeopleVisitCount { get; set; }

        /// <summary>
        /// 人均访问次数=访问次数/访问人数
        /// </summary>
        [XmlElement("people_visit_count_avg")]
        public string PeopleVisitCountAvg { get; set; }

        /// <summary>
        /// 属性名称
        /// </summary>
        [XmlElement("property")]
        public string Property { get; set; }

        /// <summary>
        /// property_value
        /// </summary>
        [XmlElement("property_value")]
        public string PropertyValue { get; set; }
    }
}
