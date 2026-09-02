using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseChannelUserrateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseChannelUserrateQueryModel : AopObject
    {
        /// <summary>
        /// 用户级抽佣分成比例请求模型
        /// </summary>
        [XmlElement("channel_user_rate_query_request")]
        public ChannelUserRateQueryRequest ChannelUserRateQueryRequest { get; set; }
    }
}
