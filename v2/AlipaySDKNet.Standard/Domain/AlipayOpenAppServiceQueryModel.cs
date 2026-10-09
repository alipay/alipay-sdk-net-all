using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppServiceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppServiceQueryModel : AopObject
    {
        /// <summary>
        /// 服务id
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }
    }
}
