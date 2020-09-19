using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppAraterWaitratealgorankQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppAraterWaitratealgorankQueryModel : AopObject
    {
        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 集团统一会员ID
        /// </summary>
        [XmlElement("havana_id")]
        public string HavanaId { get; set; }

        /// <summary>
        /// 算法打分列表
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("wait_rate_algo_item")]
        public List<WaitRateAlgoItem> ItemList { get; set; }

        /// <summary>
        /// 支付宝userId倒数2-3位
        /// </summary>
        [XmlElement("route_uid")]
        public string RouteUid { get; set; }

        /// <summary>
        /// 本次session已点击的itemIds
        /// </summary>
        [XmlArray("session_click_item_ids")]
        [XmlArrayItem("string")]
        public List<string> SessionClickItemIds { get; set; }

        /// <summary>
        /// 本次session已曝光的itemIds
        /// </summary>
        [XmlArray("session_expo_item_ids")]
        [XmlArrayItem("string")]
        public List<string> SessionExpoItemIds { get; set; }
    }
}
