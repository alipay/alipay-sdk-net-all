using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseUsercompanyQueryResponse.
    /// </summary>
    public class AnttechOceanbaseUsercompanyQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户所属企业列表
        /// </summary>
        [XmlArray("user_company_list")]
        [XmlArrayItem("user_company_d_t_o")]
        public List<UserCompanyDTO> UserCompanyList { get; set; }

        /// <summary>
        /// 用户组织列表
        /// </summary>
        [XmlArray("user_organization_list")]
        [XmlArrayItem("user_organization_d_t_o")]
        public List<UserOrganizationDTO> UserOrganizationList { get; set; }
    }
}
