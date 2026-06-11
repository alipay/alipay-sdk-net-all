using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalUserInfoQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalUserInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户信息
        /// </summary>
        [XmlElement("user_query_info")]
        public UserQueryInfo UserQueryInfo { get; set; }
    }
}
