using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderNpromoactivityEffectResponse.
    /// </summary>
    public class AlipayOfflineProviderNpromoactivityEffectResponse : AopResponse
    {
        /// <summary>
        /// 用户活动
        /// </summary>
        [XmlElement("activity")]
        public NPromoActivity Activity { get; set; }
    }
}
