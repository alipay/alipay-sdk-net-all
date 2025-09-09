using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpOweTaxDataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpOweTaxDataInfo : AopObject
    {
        /// <summary>
        /// 命中数据结果
        /// </summary>
        [XmlArray("hits")]
        [XmlArrayItem("ep_owe_tax_info")]
        public List<EpOweTaxInfo> Hits { get; set; }

        /// <summary>
        /// 结果总条数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
