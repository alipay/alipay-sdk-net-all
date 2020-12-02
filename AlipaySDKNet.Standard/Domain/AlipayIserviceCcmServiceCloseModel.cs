using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmServiceCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmServiceCloseModel : AopObject
    {
        /// <summary>
        /// 服务代码
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }
    }
}
