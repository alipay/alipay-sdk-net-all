using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseChannelListQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseChannelListQueryModel : AopObject
    {
        /// <summary>
        /// 用于查询所有渠道的请求入参模型
        /// </summary>
        [XmlElement("channel_list_query_request")]
        public ChannelListQueryRequest ChannelListQueryRequest { get; set; }
    }
}
