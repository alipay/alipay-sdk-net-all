using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIsresourceUrquerybybusvcdomainQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIsresourceUrquerybybusvcdomainQueryModel : AopObject
    {
        /// <summary>
        /// 域账号
        /// </summary>
        [XmlElement("busvc_domain")]
        public string BusvcDomain { get; set; }
    }
}
