using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DateRangeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DateRangeInfo : AopObject
    {
        /// <summary>
        /// 开始日期  格式：yyyy-MM-dd
        /// </summary>
        [XmlElement("begin_date")]
        public string BeginDate { get; set; }

        /// <summary>
        /// 结束日期  格式：yyyy-MM-dd
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }
    }
}
