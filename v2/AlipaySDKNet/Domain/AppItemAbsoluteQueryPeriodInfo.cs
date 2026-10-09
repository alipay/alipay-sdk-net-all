using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemAbsoluteQueryPeriodInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemAbsoluteQueryPeriodInfo : AopObject
    {
        /// <summary>
        /// 可用开始时间格式：yyyy-MM-dd HH:mm:ss 匹配格式yyyy-MM-dd HH:mm:ss的date类型
        /// </summary>
        [XmlElement("valid_begin_time")]
        public string ValidBeginTime { get; set; }

        /// <summary>
        /// 可用结束时间格式：yyyy-MM-dd HH:mm:ss 匹配格式yyyy-MM-dd HH:mm:ss的date类型
        /// </summary>
        [XmlElement("valid_end_time")]
        public string ValidEndTime { get; set; }
    }
}
