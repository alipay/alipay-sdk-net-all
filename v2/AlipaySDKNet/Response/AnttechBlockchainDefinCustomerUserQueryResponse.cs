using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainDefinCustomerUserQueryResponse.
    /// </summary>
    public class AnttechBlockchainDefinCustomerUserQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户信息
        /// </summary>
        [XmlArray("user_info_list")]
        [XmlArrayItem("defi_cust_user_d_t_o")]
        public List<DefiCustUserDTO> UserInfoList { get; set; }
    }
}
