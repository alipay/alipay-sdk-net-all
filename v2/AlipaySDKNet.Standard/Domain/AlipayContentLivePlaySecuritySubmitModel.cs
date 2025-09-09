using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayContentLivePlaySecuritySubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayContentLivePlaySecuritySubmitModel : AopObject
    {
        /// <summary>
        /// 支付宝直播id
        /// </summary>
        [XmlElement("alipay_live_id")]
        public string AlipayLiveId { get; set; }

        /// <summary>
        /// 行业标识
        /// </summary>
        [XmlElement("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// 用于标识业务请求的id
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 小蓝车内容
        /// </summary>
        [XmlArray("pocket_item_list")]
        [XmlArrayItem("live_play_security_pocket_info")]
        public List<LivePlaySecurityPocketInfo> PocketItemList { get; set; }
    }
}
