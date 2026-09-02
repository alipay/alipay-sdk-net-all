using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AdSeriesTabCompilationResp Data Structure.
    /// </summary>
    [Serializable]
    public class AdSeriesTabCompilationResp : AopObject
    {
        /// <summary>
        /// 短剧合集
        /// </summary>
        [XmlElement("compilation_id")]
        public string CompilationId { get; set; }

        /// <summary>
        /// 封面链接
        /// </summary>
        [XmlElement("cover_url")]
        public string CoverUrl { get; set; }

        /// <summary>
        /// 前端悬停提示文案
        /// </summary>
        [XmlElement("hover")]
        public string Hover { get; set; }

        /// <summary>
        /// 可投状态
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
