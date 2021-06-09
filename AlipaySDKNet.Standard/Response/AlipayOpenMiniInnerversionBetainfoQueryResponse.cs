using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerversionBetainfoQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerversionBetainfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 邀测结果列表
        /// </summary>
        [XmlArray("plugin_beta_item_list")]
        [XmlArrayItem("plugin_beta_item_info")]
        public List<PluginBetaItemInfo> PluginBetaItemList { get; set; }

        /// <summary>
        /// 邀测状态，待确认WAITCHECK/确认CHECKED/拒绝REJECT
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
