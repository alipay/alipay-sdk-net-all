using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LineRepetitionVO Data Structure.
    /// </summary>
    [Serializable]
    public class LineRepetitionVO : AopObject
    {
        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 线路重复度日期
        /// </summary>
        [XmlElement("dt")]
        public string Dt { get; set; }

        /// <summary>
        /// 线路key
        /// </summary>
        [XmlElement("line_key")]
        public string LineKey { get; set; }

        /// <summary>
        /// 重复度数据,单位:次
        /// </summary>
        [XmlElement("repetition")]
        public string Repetition { get; set; }
    }
}
