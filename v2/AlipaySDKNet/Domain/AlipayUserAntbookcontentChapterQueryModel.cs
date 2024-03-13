using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAntbookcontentChapterQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAntbookcontentChapterQueryModel : AopObject
    {
        /// <summary>
        /// 最新版本审核状态，用做过滤。如果传入AUDIT_REJECT，则只返回审核失败的章节
        /// </summary>
        [XmlElement("latest_audit_status")]
        public string LatestAuditStatus { get; set; }

        /// <summary>
        /// 三方书籍ID，分页返回该书籍下的章节信息
        /// </summary>
        [XmlElement("out_book_id")]
        public string OutBookId { get; set; }

        /// <summary>
        /// 从1开始，默认值为1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 默认值为20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
