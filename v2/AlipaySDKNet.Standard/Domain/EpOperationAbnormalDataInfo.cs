using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpOperationAbnormalDataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpOperationAbnormalDataInfo : AopObject
    {
        /// <summary>
        /// 查询内容明细列表
        /// </summary>
        [XmlArray("hits")]
        [XmlArrayItem("ep_operation_abnormal_info")]
        public List<EpOperationAbnormalInfo> Hits { get; set; }

        /// <summary>
        /// 命中记录总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
