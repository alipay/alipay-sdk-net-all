using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseUserorgentityBatchqueryResponse.
    /// </summary>
    public class AnttechOceanbaseUserorgentityBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 用户组织信息列表
        /// </summary>
        [XmlArray("user_org_entity_info_list")]
        [XmlArrayItem("user_org_entity_info_d_t_o")]
        public List<UserOrgEntityInfoDTO> UserOrgEntityInfoList { get; set; }
    }
}
