using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BookInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BookInfo : AopObject
    {
        /// <summary>
        /// 书籍审核失败原因，可能为空
        /// </summary>
        [XmlElement("audit_reject_desc")]
        public string AuditRejectDesc { get; set; }

        /// <summary>
        /// 书籍（电子书）名称
        /// </summary>
        [XmlElement("book_name")]
        public string BookName { get; set; }

        /// <summary>
        /// 书籍最新版本的审核状态，可能为空
        /// </summary>
        [XmlElement("latest_audit_status")]
        public string LatestAuditStatus { get; set; }

        /// <summary>
        /// 三方书籍id
        /// </summary>
        [XmlElement("out_book_id")]
        public string OutBookId { get; set; }

        /// <summary>
        /// 对C端用户展示的书籍上下架状态，可能为空。可能出现书籍最新版本还在审核中（latestAuditStatus=AUDIT_ING），但是上一版本已上架（status=ONLINE）情况。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
