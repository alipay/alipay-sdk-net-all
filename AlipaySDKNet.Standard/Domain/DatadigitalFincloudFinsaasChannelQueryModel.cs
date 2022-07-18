using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasChannelQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasChannelQueryModel : AopObject
    {
        /// <summary>
        /// 渠道id+唯一+获取渠道详情+数据库
        /// </summary>
        [XmlElement("channel_id")]
        public long ChannelId { get; set; }
    }
}
