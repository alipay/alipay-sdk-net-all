using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiAdvertCommissionMissionQueryResponse.
    /// </summary>
    public class KoubeiAdvertCommissionMissionQueryResponse : AopResponse
    {
        /// <summary>
        /// 分佣任务信息  该列表中的任务为已经创建成功的任务，并处于EFFECTIVE或者INVALID状态
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("kb_advert_mission_query_response")]
        public List<KbAdvertMissionQueryResponse> Data { get; set; }

        /// <summary>
        /// 创建处理中任务信息  1、只有待确认的任务（服务商代创建任务），才会出现在该列表中，如果已经确认，则在任务列表data中   2、处理中任务只返回任务状态，以及identify（用于查找任务）  3、由于未创建任务，因此不分配任务ID
        /// </summary>
        [XmlElement("processing_data")]
        public KbAdvertProcessMissionResponse ProcessingData { get; set; }
    }
}
