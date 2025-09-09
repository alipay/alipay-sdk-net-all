using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpCourtNoticeDataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpCourtNoticeDataInfo : AopObject
    {
        /// <summary>
        /// 查询内容明细列表
        /// </summary>
        [XmlArray("hits")]
        [XmlArrayItem("ep_court_notice_info")]
        public List<EpCourtNoticeInfo> Hits { get; set; }

        /// <summary>
        /// 命中记录总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
