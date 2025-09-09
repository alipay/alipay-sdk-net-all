using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusinessDateDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessDateDTO : AopObject
    {
        /// <summary>
        /// 周营业日，举例：每周一、三、五营业，则此值传["1", "3", "5"]
        /// </summary>
        [XmlArray("week_day")]
        [XmlArrayItem("string")]
        public List<string> WeekDay { get; set; }

        /// <summary>
        /// 每日的营业时间范围，比如营业时间为09:00-23:59,00:00-04:00，则传["09:00-23:59", "00:00-04:00"]
        /// </summary>
        [XmlArray("work_time")]
        [XmlArrayItem("string")]
        public List<string> WorkTime { get; set; }
    }
}
