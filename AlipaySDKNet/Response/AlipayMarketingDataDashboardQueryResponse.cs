using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingDataDashboardQueryResponse.
    /// </summary>
    public class AlipayMarketingDataDashboardQueryResponse : AopResponse
    {
        /// <summary>
        /// 仪表盘访问地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
