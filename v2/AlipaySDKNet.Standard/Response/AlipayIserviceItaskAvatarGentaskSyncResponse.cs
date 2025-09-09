using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceItaskAvatarGentaskSyncResponse.
    /// </summary>
    public class AlipayIserviceItaskAvatarGentaskSyncResponse : AopResponse
    {
        /// <summary>
        /// 数字人视频结果
        /// </summary>
        [XmlElement("avatar_task_result")]
        public AvatarHumanTaskResultDTO AvatarTaskResult { get; set; }
    }
}
