using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZolozAuthenticationCustomerFtokenConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZolozAuthenticationCustomerFtokenConfirmModel : AopObject
    {
        /// <summary>
        /// ftoken信息
        /// </summary>
        [XmlArray("ftokens")]
        [XmlArrayItem("ftoken_info_query")]
        public List<FtokenInfoQuery> Ftokens { get; set; }
    }
}
