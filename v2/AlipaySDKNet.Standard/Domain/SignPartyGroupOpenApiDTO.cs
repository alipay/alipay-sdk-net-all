using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SignPartyGroupOpenApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SignPartyGroupOpenApiDTO : AopObject
    {
        /// <summary>
        /// 签署主体列表
        /// </summary>
        [XmlArray("sign_parties")]
        [XmlArrayItem("sign_party_open_api_d_t_o")]
        public List<SignPartyOpenApiDTO> SignParties { get; set; }
    }
}
