using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusinessHoursInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessHoursInfo : AopObject
    {
        /// <summary>
        /// 营业日：周一、周二、周三、周四、周五、周六、周日
        /// </summary>
        [XmlArray("business_date")]
        [XmlArrayItem("string")]
        public List<string> BusinessDate { get; set; }

        /// <summary>
        /// 结束营业时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 其他描述
        /// </summary>
        [XmlElement("extra_desc")]
        public string ExtraDesc { get; set; }

        /// <summary>
        /// 开始营业时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
