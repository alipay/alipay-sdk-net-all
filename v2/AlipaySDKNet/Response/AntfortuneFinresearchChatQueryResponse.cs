using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneFinresearchChatQueryResponse.
    /// </summary>
    public class AntfortuneFinresearchChatQueryResponse : AopResponse
    {
        /// <summary>
        /// 消息详情
        /// </summary>
        [XmlElement("data")]
        public ZXZMessageDetail Data { get; set; }

        /// <summary>
        /// 接口请求是否成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
