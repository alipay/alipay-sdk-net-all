using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAntpaasTokenidentityCreateResponse.
    /// </summary>
    public class AlipayUserAntpaasTokenidentityCreateResponse : AopResponse
    {
        /// <summary>
        /// 蚂蚁通行证id
        /// </summary>
        [XmlElement("ant_id")]
        public string AntId { get; set; }

        /// <summary>
        /// 支付宝用户Id，即匿名用户Id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
