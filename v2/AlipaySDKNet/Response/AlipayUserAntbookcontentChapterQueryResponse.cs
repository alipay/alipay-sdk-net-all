using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAntbookcontentChapterQueryResponse.
    /// </summary>
    public class AlipayUserAntbookcontentChapterQueryResponse : AopResponse
    {
        /// <summary>
        /// 章节信息列表，列表中有记录代表已进件，无记录代表未进件或进件失败
        /// </summary>
        [XmlArray("chapter_info_list")]
        [XmlArrayItem("chapter_info")]
        public List<ChapterInfo> ChapterInfoList { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 章节总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
