using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceCodeIstd Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceCodeIstd : AopObject
    {
        /// <summary>
        /// 即时配送公司服务代码
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }
    }
}
