using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiContractCoordinatorDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiContractCoordinatorDTO : AopObject
    {
        /// <summary>
        /// 协同人
        /// </summary>
        [XmlElement("people")]
        public OpenApiPersonSaDTO People { get; set; }

        /// <summary>
        /// 磋商成员角色
        /// </summary>
        [XmlElement("role")]
        public string Role { get; set; }
    }
}
