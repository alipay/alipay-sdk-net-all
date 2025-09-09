using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneFinresearchSessionHistoryQueryResponse.
    /// </summary>
    public class AntfortuneFinresearchSessionHistoryQueryResponse : AopResponse
    {
        /// <summary>
        /// 会话列表
        /// </summary>
        [XmlElement("session_list")]
        public FinSessionDetail SessionList { get; set; }
    }
}
