using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenApidefaultparamQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenApidefaultparamQueryModel : AopObject
    {
        /// <summary>
        /// 接口名称
        /// </summary>
        [XmlElement("interface_name")]
        public string InterfaceName { get; set; }
    }
}
