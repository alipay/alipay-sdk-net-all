using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseUserorginfoQueryResponse.
    /// </summary>
    public class AnttechOceanbaseUserorginfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户基本信息
        /// </summary>
        [XmlElement("basic_info")]
        public UserInfoDetailDTO BasicInfo { get; set; }

        /// <summary>
        /// 组织信息列表
        /// </summary>
        [XmlArray("org_info_list")]
        [XmlArrayItem("user_organization_d_t_o")]
        public List<UserOrganizationDTO> OrgInfoList { get; set; }
    }
}
