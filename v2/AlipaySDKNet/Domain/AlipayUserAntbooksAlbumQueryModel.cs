using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAntbooksAlbumQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAntbooksAlbumQueryModel : AopObject
    {
        /// <summary>
        /// 最新版本审核状态，用做过滤。如果传入AUDIT_REJECT，则只返回审核失败的专辑
        /// </summary>
        [XmlElement("latest_audit_status")]
        public string LatestAuditStatus { get; set; }

        /// <summary>
        /// 三方专辑id列表，长度不能超过20。如果传入，则只返回输入id列表范围内的专辑信息。
        /// </summary>
        [XmlArray("out_album_id_list")]
        [XmlArrayItem("string")]
        public List<string> OutAlbumIdList { get; set; }

        /// <summary>
        /// 从1开始，默认为1。如果out_album_id_list为空，默认按照分页查询。
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 默认为20。如果out_album_id_list为空，默认按照分页查询。
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
