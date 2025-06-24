using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustrySecurityKnowledgeCheckResponse.
    /// </summary>
    public class AlipayEbppIndustrySecurityKnowledgeCheckResponse : AopResponse
    {
        /// <summary>
        /// 检测未通过链接的索引列表
        /// </summary>
        [XmlArray("no_passed_link_index_list")]
        [XmlArrayItem("number")]
        public List<long> NoPassedLinkIndexList { get; set; }

        /// <summary>
        /// 检测未通过图片的索引列表
        /// </summary>
        [XmlArray("no_passed_pic_url_index_list")]
        [XmlArrayItem("number")]
        public List<long> NoPassedPicUrlIndexList { get; set; }

        /// <summary>
        /// 参数中传递的未通过检测的文本索引位置
        /// </summary>
        [XmlArray("no_passed_text_index_list")]
        [XmlArrayItem("number")]
        public List<long> NoPassedTextIndexList { get; set; }

        /// <summary>
        /// 检测是否安全
        /// </summary>
        [XmlElement("safe")]
        public bool Safe { get; set; }
    }
}
