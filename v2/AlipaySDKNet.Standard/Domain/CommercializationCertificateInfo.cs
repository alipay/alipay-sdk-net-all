using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommercializationCertificateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CommercializationCertificateInfo : AopObject
    {
        /// <summary>
        /// 商家侧凭证的唯一标识
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 在某个业务单下的锁定次数，不填默认1
        /// </summary>
        [XmlElement("total_times")]
        public long TotalTimes { get; set; }
    }
}
