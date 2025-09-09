using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnswerServiceDetail Data Structure.
    /// </summary>
    [Serializable]
    public class AnswerServiceDetail : AopObject
    {
        /// <summary>
        /// 推荐服务的描述信息
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 服务id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 推荐服务展示logo图片链接地址
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 推荐服务的标题信息
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 推荐服务的跳转链接。外部机构链接，不包含扩展字段。
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
