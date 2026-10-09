using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpLitigationNoticeDataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpLitigationNoticeDataInfo : AopObject
    {
        /// <summary>
        /// 查询命中明细列表
        /// </summary>
        [XmlArray("hits")]
        [XmlArrayItem("ep_litigation_notice_info")]
        public List<EpLitigationNoticeInfo> Hits { get; set; }

        /// <summary>
        /// 命中记录总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
