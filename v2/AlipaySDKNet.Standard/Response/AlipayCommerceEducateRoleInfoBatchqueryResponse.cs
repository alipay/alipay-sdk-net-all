using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateRoleInfoBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceEducateRoleInfoBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 角色列表
        /// </summary>
        [XmlArray("role_list")]
        [XmlArrayItem("edu_role_info")]
        public List<EduRoleInfo> RoleList { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }
    }
}
