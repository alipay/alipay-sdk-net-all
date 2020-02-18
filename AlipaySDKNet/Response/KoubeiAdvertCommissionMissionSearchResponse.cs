using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiAdvertCommissionMissionSearchResponse.
    /// </summary>
    public class KoubeiAdvertCommissionMissionSearchResponse : AopResponse
    {
        /// <summary>
        /// 业务结果-任务列表
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("kb_advert_mission_response")]
        public List<KbAdvertMissionResponse> Data { get; set; }

        /// <summary>
        /// 当前页码，默认1
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 每页记录数，默认10，最大100
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
