using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainDefinSaasAccountQueryResponse.
    /// </summary>
    public class AnttechBlockchainDefinSaasAccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 账号列表
        /// </summary>
        [XmlArray("accounts")]
        [XmlArrayItem("account_v_o")]
        public List<AccountVO> Accounts { get; set; }

        /// <summary>
        /// 外部业务平台会员ID
        /// </summary>
        [XmlElement("out_member_id")]
        public string OutMemberId { get; set; }
    }
}
