using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScheduleConfigItem Data Structure.
    /// </summary>
    [Serializable]
    public class ScheduleConfigItem : AopObject
    {
        /// <summary>
        /// 配制名称
        /// </summary>
        [XmlElement("config_name")]
        public string ConfigName { get; set; }

        /// <summary>
        /// 日期列表
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
