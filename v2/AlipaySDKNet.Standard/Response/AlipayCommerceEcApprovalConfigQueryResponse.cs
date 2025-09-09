using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcApprovalConfigQueryResponse.
    /// </summary>
    public class AlipayCommerceEcApprovalConfigQueryResponse : AopResponse
    {
        /// <summary>
        /// 审批单配置列表
        /// </summary>
        [XmlArray("config_list")]
        [XmlArrayItem("approval_config_d_t_o")]
        public List<ApprovalConfigDTO> ConfigList { get; set; }
    }
}
