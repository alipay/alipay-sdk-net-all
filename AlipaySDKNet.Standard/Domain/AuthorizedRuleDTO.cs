using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AuthorizedRuleDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AuthorizedRuleDTO : AopObject
    {
        /// <summary>
        /// 授权商户列表
        /// </summary>
        [XmlArray("authorized_detail_list")]
        [XmlArrayItem("authorize_detail_d_t_o")]
        public List<AuthorizeDetailDTO> AuthorizedDetailList { get; set; }

        /// <summary>
        /// WHITELIST-白名单 ALL-全部
        /// </summary>
        [XmlElement("authorized_type")]
        public string AuthorizedType { get; set; }
    }
}
