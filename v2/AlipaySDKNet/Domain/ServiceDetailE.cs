using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceDetailE Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceDetailE : AopObject
    {
        /// <summary>
        /// 备注信息
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }
    }
}
