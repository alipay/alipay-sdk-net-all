using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppAppcontentFunctionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppAppcontentFunctionQueryModel : AopObject
    {
        /// <summary>
        /// 服务编码
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }
    }
}
