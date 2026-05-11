using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAtechspayToolQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAtechspayToolQueryModel : AopObject
    {
        /// <summary>
        /// 查询结束时间，格式 yyyy-MM-dd HH:mm:ss。不传时默认取当前时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 环境标识。sandbox：沙箱环境；online：线上环境
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }

        /// <summary>
        /// 排查关键词
        /// </summary>
        [XmlElement("keyword")]
        public string Keyword { get; set; }

        /// <summary>
        /// 查询起始时间，格式 yyyy-MM-dd HH:mm:ss。不传时默认取当前时间前推7天
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 诊断工具标识。
        /// </summary>
        [XmlElement("tool")]
        public string Tool { get; set; }
    }
}
