using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainDefinCustomerMappedidQueryResponse.
    /// </summary>
    public class AnttechBlockchainDefinCustomerMappedidQueryResponse : AopResponse
    {
        /// <summary>
        /// 会员信息
        /// </summary>
        [XmlArray("user_info_list")]
        [XmlArrayItem("defi_cust_user_d_t_o")]
        public List<DefiCustUserDTO> UserInfoList { get; set; }
    }
}
