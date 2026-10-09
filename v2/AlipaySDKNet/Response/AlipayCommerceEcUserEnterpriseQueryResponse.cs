using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcUserEnterpriseQueryResponse.
    /// </summary>
    public class AlipayCommerceEcUserEnterpriseQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户所属企业列表
        /// </summary>
        [XmlArray("enterprise_info_list")]
        [XmlArrayItem("enterprise_info_d_t_o")]
        public List<EnterpriseInfoDTO> EnterpriseInfoList { get; set; }
    }
}
