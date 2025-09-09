using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupGroupmemberQuerystatusModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupGroupmemberQuerystatusModel : AopObject
    {
        /// <summary>
        /// 群组id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户uid，2088
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
