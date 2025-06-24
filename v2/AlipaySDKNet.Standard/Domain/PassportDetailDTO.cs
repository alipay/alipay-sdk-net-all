using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PassportDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PassportDetailDTO : AopObject
    {
        /// <summary>
        /// 用于返回关联企业名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 成员用户信息
        /// </summary>
        [XmlElement("member")]
        public MemberDTO Member { get; set; }

        /// <summary>
        /// 账号信息
        /// </summary>
        [XmlArray("pass_accounts")]
        [XmlArrayItem("pass_account_d_t_o")]
        public List<PassAccountDTO> PassAccounts { get; set; }

        /// <summary>
        /// 通行证状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
