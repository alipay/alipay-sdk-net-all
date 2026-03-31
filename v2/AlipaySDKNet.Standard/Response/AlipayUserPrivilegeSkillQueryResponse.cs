using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserPrivilegeSkillQueryResponse.
    /// </summary>
    public class AlipayUserPrivilegeSkillQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户的特权基础信息
        /// </summary>
        [XmlArray("simple_open_api_privilege_detail_list")]
        [XmlArrayItem("simple_open_api_privilege_detail")]
        public List<SimpleOpenApiPrivilegeDetail> SimpleOpenApiPrivilegeDetailList { get; set; }
    }
}
