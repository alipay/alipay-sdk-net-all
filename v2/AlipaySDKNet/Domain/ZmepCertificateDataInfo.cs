using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZmepCertificateDataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ZmepCertificateDataInfo : AopObject
    {
        /// <summary>
        /// 命中数据结果
        /// </summary>
        [XmlArray("hits")]
        [XmlArrayItem("zmep_certificate_info")]
        public List<ZmepCertificateInfo> Hits { get; set; }

        /// <summary>
        /// 记录条数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
