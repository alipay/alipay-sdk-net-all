using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateManagerDetailQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateManagerDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 管理员信息
        /// </summary>
        [XmlElement("manager_info")]
        public EduManagerInfo ManagerInfo { get; set; }
    }
}
