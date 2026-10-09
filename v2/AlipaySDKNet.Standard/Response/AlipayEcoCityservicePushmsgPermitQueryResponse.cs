using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoCityservicePushmsgPermitQueryResponse.
    /// </summary>
    public class AlipayEcoCityservicePushmsgPermitQueryResponse : AopResponse
    {
        /// <summary>
        /// 根据查询条件返回匹配用户列表,包含用户id以及消息推送授权状态
        /// </summary>
        [XmlArray("user_permit_list")]
        [XmlArrayItem("user_permit")]
        public List<UserPermit> UserPermitList { get; set; }
    }
}
