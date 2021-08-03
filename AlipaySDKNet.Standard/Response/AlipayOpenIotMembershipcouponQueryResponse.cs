using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotMembershipcouponQueryResponse.
    /// </summary>
    public class AlipayOpenIotMembershipcouponQueryResponse : AopResponse
    {
        /// <summary>
        /// 活动ID，用于获取相应的活动信息，来源于商家在B站的配置
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 配置商家发券时使用的商家信息，需要和进入商家中心（B站）时使用的相同
        /// </summary>
        [XmlElement("auth_pid")]
        public string AuthPid { get; set; }
    }
}
