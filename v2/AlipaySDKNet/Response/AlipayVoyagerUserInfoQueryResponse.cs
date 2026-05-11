using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayVoyagerUserInfoQueryResponse.
    /// </summary>
    public class AlipayVoyagerUserInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// Voyager基础用户信息
        /// </summary>
        [XmlElement("user_info")]
        public VoyagerUserInfo UserInfo { get; set; }
    }
}
