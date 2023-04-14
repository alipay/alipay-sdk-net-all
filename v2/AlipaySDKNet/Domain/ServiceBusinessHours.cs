using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceBusinessHours Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceBusinessHours : AopObject
    {
        /// <summary>
        /// business_time对应的营业周期
        /// </summary>
        [XmlArray("business_date")]
        [XmlArrayItem("string")]
        public List<string> BusinessDate { get; set; }

        /// <summary>
        /// 营业时间段,示例：[             {                 "start_time":"10:00",                 "end_time":"14:00"             },             {                 "start_time":"16:00",                 "end_time":"20:00"             }         ]
        /// </summary>
        [XmlArray("business_time")]
        [XmlArrayItem("business_time")]
        public List<BusinessTime> BusinessTime { get; set; }
    }
}
