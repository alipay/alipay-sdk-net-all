using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubServiceKeyWordInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SubServiceKeyWordInfo : AopObject
    {
        /// <summary>
        /// 小程序名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 此服务下的关键词
        /// </summary>
        [XmlArray("keyword_info")]
        [XmlArrayItem("key_word_info")]
        public List<KeyWordInfo> KeywordInfo { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 子服务code
        /// </summary>
        [XmlElement("sub_service_code")]
        public string SubServiceCode { get; set; }

        /// <summary>
        /// 子服务简单描述
        /// </summary>
        [XmlElement("sub_service_desc")]
        public string SubServiceDesc { get; set; }

        /// <summary>
        /// 子服务名
        /// </summary>
        [XmlElement("sub_service_name")]
        public string SubServiceName { get; set; }

        /// <summary>
        /// 子服务状态， INITIAL：初始化：VALID:已生效；INVALID：已失效
        /// </summary>
        [XmlElement("sub_service_status")]
        public string SubServiceStatus { get; set; }
    }
}
