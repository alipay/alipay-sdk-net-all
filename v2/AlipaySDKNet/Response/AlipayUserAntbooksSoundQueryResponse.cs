using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAntbooksSoundQueryResponse.
    /// </summary>
    public class AlipayUserAntbooksSoundQueryResponse : AopResponse
    {
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
        /// 声音信息列表
        /// </summary>
        [XmlArray("sound_info_list")]
        [XmlArrayItem("sound_info")]
        public List<SoundInfo> SoundInfoList { get; set; }

        /// <summary>
        /// 声音总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
