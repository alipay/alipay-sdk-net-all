using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAntbooksAlbumQueryResponse.
    /// </summary>
    public class AlipayUserAntbooksAlbumQueryResponse : AopResponse
    {
        /// <summary>
        /// 专辑信息列表
        /// </summary>
        [XmlArray("album_info_list")]
        [XmlArrayItem("album_info")]
        public List<AlbumInfo> AlbumInfoList { get; set; }

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
        /// 专辑总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
