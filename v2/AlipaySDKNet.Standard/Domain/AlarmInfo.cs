using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlarmInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AlarmInfo : AopObject
    {
        /// <summary>
        /// 6位国标码，支持传区县+城市级别
        /// </summary>
        [XmlElement("ad_code")]
        public string AdCode { get; set; }

        /// <summary>
        /// 天气预警描述信息
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 预警级别，一般包含蓝色，黄色，橙色，红色
        /// </summary>
        [XmlElement("level")]
        public string Level { get; set; }

        /// <summary>
        /// 天气预警唯一id
        /// </summary>
        [XmlElement("out_id")]
        public string OutId { get; set; }

        /// <summary>
        /// 标准时间格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("time")]
        public string Time { get; set; }

        /// <summary>
        /// 天气预警的标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 天气预警类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
