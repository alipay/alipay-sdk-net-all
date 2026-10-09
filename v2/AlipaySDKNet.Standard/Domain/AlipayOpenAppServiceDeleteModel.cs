using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppServiceDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppServiceDeleteModel : AopObject
    {
        /// <summary>
        /// 服务id
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }
    }
}
