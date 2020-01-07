using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantActivityParticipationQueryResponse.
    /// </summary>
    public class ZhimaMerchantActivityParticipationQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户参加活动模型
        /// </summary>
        [XmlElement("activity_participation")]
        public ActivityParticipation ActivityParticipation { get; set; }
    }
}
