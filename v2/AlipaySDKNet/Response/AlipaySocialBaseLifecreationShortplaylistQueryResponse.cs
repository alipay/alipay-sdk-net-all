using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialBaseLifecreationShortplaylistQueryResponse.
    /// </summary>
    public class AlipaySocialBaseLifecreationShortplaylistQueryResponse : AopResponse
    {
        /// <summary>
        /// 剧目列表
        /// </summary>
        [XmlArray("album_info_list")]
        [XmlArrayItem("short_play_album_info")]
        public List<ShortPlayAlbumInfo> AlbumInfoList { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页条目数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
