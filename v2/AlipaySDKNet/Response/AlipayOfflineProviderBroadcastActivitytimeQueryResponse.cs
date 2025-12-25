using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderBroadcastActivitytimeQueryResponse.
    /// </summary>
    public class AlipayOfflineProviderBroadcastActivitytimeQueryResponse : AopResponse
    {
        /// <summary>
        /// 分页每页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 碰音箱激活时间数据集合
        /// </summary>
        [XmlArray("speaker_activity_list")]
        [XmlArrayItem("speaker_activity_item")]
        public List<SpeakerActivityItem> SpeakerActivityList { get; set; }

        /// <summary>
        /// 数据总条数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
