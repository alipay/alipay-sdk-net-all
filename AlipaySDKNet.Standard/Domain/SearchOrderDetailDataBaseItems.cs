using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchOrderDetailDataBaseItems Data Structure.
    /// </summary>
    [Serializable]
    public class SearchOrderDetailDataBaseItems : AopObject
    {
        /// <summary>
        /// 搜索可见性
        /// </summary>
        [XmlElement("can_search")]
        public string CanSearch { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// img地址
        /// </summary>
        [XmlElement("img")]
        public string Img { get; set; }

        /// <summary>
        /// 关键词
        /// </summary>
        [XmlElement("key_word")]
        public string KeyWord { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 基础工单详情region
        /// </summary>
        [XmlElement("region")]
        public string Region { get; set; }

        /// <summary>
        /// 搜索可见性
        /// </summary>
        [XmlElement("serv_can_search")]
        public string ServCanSearch { get; set; }

        /// <summary>
        /// 搜索关键词
        /// </summary>
        [XmlElement("serv_search_keywords")]
        public string ServSearchKeywords { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 跳转url链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
