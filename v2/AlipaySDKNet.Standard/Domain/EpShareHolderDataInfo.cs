using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpShareHolderDataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpShareHolderDataInfo : AopObject
    {
        /// <summary>
        /// 企业股东信息
        /// </summary>
        [XmlArray("hits")]
        [XmlArrayItem("ep_share_holder_info")]
        public List<EpShareHolderInfo> Hits { get; set; }

        /// <summary>
        /// 命中记录总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
