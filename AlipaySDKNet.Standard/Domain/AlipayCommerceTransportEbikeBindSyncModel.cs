using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEbikeBindSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEbikeBindSyncModel : AopObject
    {
        /// <summary>
        /// 电动车品牌绑定状态列表
        /// </summary>
        [XmlArray("ebike_bind_list")]
        [XmlArrayItem("ebike_bind_info")]
        public List<EbikeBindInfo> EbikeBindList { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [XmlElement("ebike_source")]
        public string EbikeSource { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID（对外）
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
