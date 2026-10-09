using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemAbsoluteModifyPeriodInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemAbsoluteModifyPeriodInfo : AopObject
    {
        /// <summary>
        /// 可用结束时间格式：yyyy-MM-dd HH:mm:ss 匹配格式yyyy-MM-dd HH:mm:ss的date类型
        /// </summary>
        [XmlElement("valid_end_time")]
        public string ValidEndTime { get; set; }
    }
}
