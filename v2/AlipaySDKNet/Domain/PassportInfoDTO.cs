using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PassportInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PassportInfoDTO : AopObject
    {
        /// <summary>
        /// 账号注册信息
        /// </summary>
        [XmlArray("pass_accounts")]
        [XmlArrayItem("pass_account_d_t_o")]
        public List<PassAccountDTO> PassAccounts { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }

        /// <summary>
        /// 0是商业官网，1是开源官网
        /// </summary>
        [XmlElement("register_from")]
        public string RegisterFrom { get; set; }

        /// <summary>
        /// 注册时间
        /// </summary>
        [XmlElement("register_time")]
        public string RegisterTime { get; set; }
    }
}
