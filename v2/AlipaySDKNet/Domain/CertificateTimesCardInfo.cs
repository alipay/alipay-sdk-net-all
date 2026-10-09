using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CertificateTimesCardInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CertificateTimesCardInfo : AopObject
    {
        /// <summary>
        /// 次卡次序号信息
        /// </summary>
        [XmlArray("serial_info_list")]
        [XmlArrayItem("certificate_serial_info")]
        public List<CertificateSerialInfo> SerialInfoList { get; set; }

        /// <summary>
        /// 次卡总次数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 已使用次数
        /// </summary>
        [XmlElement("used_count")]
        public long UsedCount { get; set; }
    }
}
