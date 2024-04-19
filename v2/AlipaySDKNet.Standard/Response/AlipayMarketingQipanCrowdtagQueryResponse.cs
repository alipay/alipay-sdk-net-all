using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingQipanCrowdtagQueryResponse.
    /// </summary>
    public class AlipayMarketingQipanCrowdtagQueryResponse : AopResponse
    {
        /// <summary>
        /// 棋盘开放圈选查询标签值返回
        /// </summary>
        [XmlArray("select_tag_list")]
        [XmlArrayItem("crowd_select_tag_open")]
        public List<CrowdSelectTagOpen> SelectTagList { get; set; }
    }
}
