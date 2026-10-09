using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CalendarInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CalendarInfoDTO : AopObject
    {
        /// <summary>
        /// 日历维度重复类型，支持工作日（WORK_DAY）和每天（DAILY）
        /// </summary>
        [XmlElement("calendar_type")]
        public string CalendarType { get; set; }

        /// <summary>
        /// 如上面示例值表示每月的1，3，5，7，9号，余额提醒暂不支持
        /// </summary>
        [XmlArray("day_list")]
        [XmlArrayItem("string")]
        public List<string> DayList { get; set; }
    }
}
