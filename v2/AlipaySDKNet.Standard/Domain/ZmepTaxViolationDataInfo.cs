using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZmepTaxViolationDataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ZmepTaxViolationDataInfo : AopObject
    {
        /// <summary>
        /// 命中数据结果
        /// </summary>
        [XmlArray("hits")]
        [XmlArrayItem("zmep_tax_violation_info")]
        public List<ZmepTaxViolationInfo> Hits { get; set; }

        /// <summary>
        /// 结果集总记录数
        /// </summary>
        [XmlElement("total")]
        public string Total { get; set; }
    }
}
