using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceItaskAvatarQuerytaskQueryResponse.
    /// </summary>
    public class AlipayIserviceItaskAvatarQuerytaskQueryResponse : AopResponse
    {
        /// <summary>
        /// 请求结果
        /// </summary>
        [XmlArray("avatar_task_results")]
        [XmlArrayItem("avatar_human_task_result_d_t_o")]
        public List<AvatarHumanTaskResultDTO> AvatarTaskResults { get; set; }
    }
}
