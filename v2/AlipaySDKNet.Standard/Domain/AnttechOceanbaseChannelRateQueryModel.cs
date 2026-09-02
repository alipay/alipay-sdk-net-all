using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseChannelRateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseChannelRateQueryModel : AopObject
    {
        /// <summary>
        /// 渠道抽佣分成比例的请求模型
        /// </summary>
        [XmlElement("channel_rate_query_request")]
        public ChannelRateQueryRequest ChannelRateQueryRequest { get; set; }
    }
}
