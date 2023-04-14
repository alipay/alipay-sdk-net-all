using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEtcSellerconfigQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEtcSellerconfigQueryModel : AopObject
    {
        /// <summary>
        /// 外部宿主商户（ISV）的appid
        /// </summary>
        [XmlElement("agent_appid")]
        public string AgentAppid { get; set; }

        /// <summary>
        /// 外部宿主商户（ISV）的pid
        /// </summary>
        [XmlElement("agent_pid")]
        public string AgentPid { get; set; }

        /// <summary>
        /// 蚂蚁会员统一ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 需要查询的发行方信息配置类目
        /// </summary>
        [XmlArray("query_scopes")]
        [XmlArrayItem("string")]
        public List<string> QueryScopes { get; set; }

        /// <summary>
        /// 发行方的标识ID
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
