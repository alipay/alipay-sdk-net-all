using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FqQrCodeExtendParams Data Structure.
    /// </summary>
    [Serializable]
    public class FqQrCodeExtendParams : AopObject
    {
        /// <summary>
        /// 分期数
        /// </summary>
        [XmlElement("fq_num")]
        public string FqNum { get; set; }
    }
}
