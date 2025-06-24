using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustrySecurityKnowledgeCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustrySecurityKnowledgeCheckModel : AopObject
    {
        /// <summary>
        /// 调用方传递的当次安全检测业务id ,当深度检测有风险时会通过SPI 回调，并传递该id
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 对链接自身的黑白名单检测，不涉及链接里的内容
        /// </summary>
        [XmlArray("link_list")]
        [XmlArrayItem("string")]
        public List<string> LinkList { get; set; }

        /// <summary>
        /// 图片的安全检测
        /// </summary>
        [XmlArray("pic_url_list")]
        [XmlArrayItem("string")]
        public List<string> PicUrlList { get; set; }

        /// <summary>
        /// 文本安全检测，支持数组形式
        /// </summary>
        [XmlArray("text_list")]
        [XmlArrayItem("string")]
        public List<string> TextList { get; set; }
    }
}
