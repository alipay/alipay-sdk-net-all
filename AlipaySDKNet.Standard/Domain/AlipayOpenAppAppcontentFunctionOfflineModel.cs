using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppAppcontentFunctionOfflineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppAppcontentFunctionOfflineModel : AopObject
    {
        /// <summary>
        /// 服务编码
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }
    }
}
