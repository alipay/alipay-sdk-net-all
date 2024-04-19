using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAntpaasTokenidentityQueryResponse.
    /// </summary>
    public class AlipayUserAntpaasTokenidentityQueryResponse : AopResponse
    {
        /// <summary>
        /// 蚂蚁通行证Id
        /// </summary>
        [XmlElement("ant_id")]
        public string AntId { get; set; }

        /// <summary>
        /// 扩展信息,业务方在创建匿名用户时设置的扩展信息。
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 支付宝用户Id，即匿名用户Id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
