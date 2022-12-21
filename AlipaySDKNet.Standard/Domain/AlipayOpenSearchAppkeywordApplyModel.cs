using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSearchAppkeywordApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSearchAppkeywordApplyModel : AopObject
    {
        /// <summary>
        /// 关键词id，（仅修改时传入，修改时仅能传一个关键词）
        /// </summary>
        [XmlElement("config_id")]
        public string ConfigId { get; set; }

        /// <summary>
        /// 提报的关键词
        /// </summary>
        [XmlArray("key_words")]
        [XmlArrayItem("string")]
        public List<string> KeyWords { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("target_appid")]
        public string TargetAppid { get; set; }
    }
}
