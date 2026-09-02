using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExchangeRecordResult Data Structure.
    /// </summary>
    [Serializable]
    public class ExchangeRecordResult : AopObject
    {
        /// <summary>
        /// 记录级认证状态（0-未认证，1-已认证）
        /// </summary>
        [XmlElement("cert_status")]
        public long CertStatus { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("fields")]
        [XmlArrayItem("field_info_result")]
        public List<FieldInfoResult> Fields { get; set; }
    }
}
