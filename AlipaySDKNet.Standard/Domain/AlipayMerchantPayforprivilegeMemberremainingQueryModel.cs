using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantPayforprivilegeMemberremainingQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantPayforprivilegeMemberremainingQueryModel : AopObject
    {
        /// <summary>
        /// 该字段已废弃，请通过user_id查询
        /// </summary>
        [XmlElement("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
