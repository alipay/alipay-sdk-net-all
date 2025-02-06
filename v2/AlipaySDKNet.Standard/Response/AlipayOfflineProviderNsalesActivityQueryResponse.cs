using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderNsalesActivityQueryResponse.
    /// </summary>
    public class AlipayOfflineProviderNsalesActivityQueryResponse : AopResponse
    {
        /// <summary>
        /// 卖进订单活动信息
        /// </summary>
        [XmlElement("activity")]
        public NSalesActivity Activity { get; set; }
    }
}
