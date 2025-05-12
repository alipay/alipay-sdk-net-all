using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdcampaignBatchcreativestatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdcampaignBatchcreativestatusModifyModel : AopObject
    {
        /// <summary>
        /// 创意id集合
        /// </summary>
        [XmlArray("ids")]
        [XmlArrayItem("number")]
        public List<long> Ids { get; set; }

        /// <summary>
        /// 创意操作类型(ENABLE（启用）/PAUSE（暂停）)
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 商家标志,唯一值,在广告投放平台商家详情获取
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }
    }
}
