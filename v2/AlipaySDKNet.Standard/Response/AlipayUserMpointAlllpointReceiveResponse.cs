using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserMpointAlllpointReceiveResponse.
    /// </summary>
    public class AlipayUserMpointAlllpointReceiveResponse : AopResponse
    {
        /// <summary>
        /// 用户领取状态为SUCCESS时该值才有意义，表示同步领取成功获得的积分数
        /// </summary>
        [XmlElement("point")]
        public long Point { get; set; }

        /// <summary>
        /// 如果用户待领取积分较少为同步领取，返回SUCCESS 如果用户待领取积分较多则为异步领取，返回DOING
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
