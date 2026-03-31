using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserMpointPointcertQueryResponse.
    /// </summary>
    public class AlipayUserMpointPointcertQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户待领取积分数量
        /// </summary>
        [XmlElement("point")]
        public long Point { get; set; }
    }
}
