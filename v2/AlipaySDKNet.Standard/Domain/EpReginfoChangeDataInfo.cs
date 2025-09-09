using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpReginfoChangeDataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpReginfoChangeDataInfo : AopObject
    {
        /// <summary>
        /// 企业工商变更明细列表
        /// </summary>
        [XmlArray("hits")]
        [XmlArrayItem("ep_reginfo_change_info")]
        public List<EpReginfoChangeInfo> Hits { get; set; }

        /// <summary>
        /// 命中记录总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
