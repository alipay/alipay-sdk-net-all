using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiAdvertCommissionMissionPromoteResponse.
    /// </summary>
    public class KoubeiAdvertCommissionMissionPromoteResponse : AopResponse
    {
        /// <summary>
        /// 广告详情
        /// </summary>
        [XmlElement("advert")]
        public KbAdvertAdvResponse Advert { get; set; }

        /// <summary>
        /// true:可以二级分佣配置  false:不可以
        /// </summary>
        [XmlElement("can_cascade_mission")]
        public string CanCascadeMission { get; set; }
    }
}
