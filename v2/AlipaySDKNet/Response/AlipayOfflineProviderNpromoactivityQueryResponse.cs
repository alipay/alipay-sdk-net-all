using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderNpromoactivityQueryResponse.
    /// </summary>
    public class AlipayOfflineProviderNpromoactivityQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户活动
        /// </summary>
        [XmlElement("activity")]
        public NPromoActivity Activity { get; set; }
    }
}
