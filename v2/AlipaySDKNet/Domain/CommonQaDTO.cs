using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommonQaDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CommonQaDTO : AopObject
    {
        /// <summary>
        /// 城市code
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// faq的回答内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 机构统一定义的faq问答对的统一id，要求唯一性
        /// </summary>
        [XmlElement("out_faq_id")]
        public string OutFaqId { get; set; }

        /// <summary>
        /// 用于描述该faq问答对的发布单位
        /// </summary>
        [XmlElement("report_department")]
        public string ReportDepartment { get; set; }

        /// <summary>
        /// 语料状态
        /// </summary>
        [XmlElement("run_status")]
        public string RunStatus { get; set; }

        /// <summary>
        /// FAQ问答的问题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
