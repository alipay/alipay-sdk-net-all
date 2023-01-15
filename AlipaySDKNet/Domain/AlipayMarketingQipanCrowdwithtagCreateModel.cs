using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingQipanCrowdwithtagCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingQipanCrowdwithtagCreateModel : AopObject
    {
        /// <summary>
        /// 安全应用范围，参考文档
        /// </summary>
        [XmlArray("apply_channel_list")]
        [XmlArrayItem("string")]
        public List<string> ApplyChannelList { get; set; }

        /// <summary>
        /// 棋盘商家人群描述
        /// </summary>
        [XmlElement("crowd_desc")]
        public string CrowdDesc { get; set; }

        /// <summary>
        /// 人群id，人群加工必选
        /// </summary>
        [XmlElement("crowd_id")]
        public string CrowdId { get; set; }

        /// <summary>
        /// 商家棋盘人群名称
        /// </summary>
        [XmlElement("crowd_name")]
        public string CrowdName { get; set; }

        /// <summary>
        /// 人群标签值列表
        /// </summary>
        [XmlArray("select_tag_list")]
        [XmlArrayItem("crowd_select_tag_open_request")]
        public List<CrowdSelectTagOpenRequest> SelectTagList { get; set; }
    }
}
