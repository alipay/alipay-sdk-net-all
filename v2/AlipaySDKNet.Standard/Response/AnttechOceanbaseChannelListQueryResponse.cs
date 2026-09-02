using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseChannelListQueryResponse.
    /// </summary>
    public class AnttechOceanbaseChannelListQueryResponse : AopResponse
    {
        /// <summary>
        /// 渠道列表
        /// </summary>
        [XmlArray("channels")]
        [XmlArrayItem("channel_list")]
        public List<ChannelList> Channels { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
