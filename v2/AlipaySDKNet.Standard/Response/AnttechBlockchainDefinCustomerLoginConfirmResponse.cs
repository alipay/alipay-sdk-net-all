using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainDefinCustomerLoginConfirmResponse.
    /// </summary>
    public class AnttechBlockchainDefinCustomerLoginConfirmResponse : AopResponse
    {
        /// <summary>
        /// 用户信息
        /// </summary>
        [XmlElement("user_info")]
        public DefiCustUserDTO UserInfo { get; set; }
    }
}
