using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniMarketReceivedConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniMarketReceivedConsultModel : AopObject
    {
        /// <summary>
        /// 投放活动id
        /// </summary>
        [XmlElement("deliver_id")]
        public string DeliverId { get; set; }

        /// <summary>
        /// 投放活动id集合
        /// </summary>
        [XmlArray("deliver_id_list")]
        [XmlArrayItem("string")]
        public List<string> DeliverIdList { get; set; }

        /// <summary>
        /// 是否为多个投放，是为true，若是则deliver_id_list必填，若否则deliver_id必填
        /// </summary>
        [XmlElement("multi_deliver")]
        public bool MultiDeliver { get; set; }

        /// <summary>
        /// 商户小程序中的用户id
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
