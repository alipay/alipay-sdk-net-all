using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAntbookcontentBookQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAntbookcontentBookQueryModel : AopObject
    {
        /// <summary>
        /// 最新版本审核状态，用做过滤。如果传入AUDIT_REJECT，则只返回审核失败的书籍
        /// </summary>
        [XmlElement("latest_audit_status")]
        public string LatestAuditStatus { get; set; }

        /// <summary>
        /// 三方书籍id列表，长度不能超过20。如果传入，则只返回输入id列表范围内的书籍信息。
        /// </summary>
        [XmlArray("out_book_id_list")]
        [XmlArrayItem("string")]
        public List<string> OutBookIdList { get; set; }

        /// <summary>
        /// 从1开始。如果bookIdList为空，默认为1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 如果bookIdList为空，默认为20，按照进件时间倒序查询
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
