using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FqNumChargeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FqNumChargeInfo : AopObject
    {
        /// <summary>
        /// 分期数
        /// </summary>
        [XmlElement("term")]
        public string Term { get; set; }
    }
}
