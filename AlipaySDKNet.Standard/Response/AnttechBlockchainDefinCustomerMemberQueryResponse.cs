using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainDefinCustomerMemberQueryResponse.
    /// </summary>
    public class AnttechBlockchainDefinCustomerMemberQueryResponse : AopResponse
    {
        /// <summary>
        /// 会员对象
        /// </summary>
        [XmlArray("member_info_list")]
        [XmlArrayItem("defi_cust_member_d_t_o")]
        public List<DefiCustMemberDTO> MemberInfoList { get; set; }
    }
}
