using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlbumInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AlbumInfo : AopObject
    {
        /// <summary>
        /// 专辑名称
        /// </summary>
        [XmlElement("album_name")]
        public string AlbumName { get; set; }

        /// <summary>
        /// 审核失败原因，可能为空
        /// </summary>
        [XmlElement("audit_reject_desc")]
        public string AuditRejectDesc { get; set; }

        /// <summary>
        /// 专辑最新版本的审核状态，可能为空
        /// </summary>
        [XmlElement("latest_audit_status")]
        public string LatestAuditStatus { get; set; }

        /// <summary>
        /// 三方专辑id
        /// </summary>
        [XmlElement("out_album_id")]
        public string OutAlbumId { get; set; }

        /// <summary>
        /// 对C端用户展示的专辑上下架状态，可能为空。可能出现专辑最新版本还在审核中（latestAuditStatus=AUDIT_ING），但是上一版本已上架（status=ONLINE）情况。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
