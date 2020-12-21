using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmRoleCreateResponse.
    /// </summary>
    public class AlipayIserviceCcmRoleCreateResponse : AopResponse
    {
        /// <summary>
        /// 角色id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
