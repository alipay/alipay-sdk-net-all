using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalCommercialUserAuthResponse.
    /// </summary>
    public class AlipayCommerceMedicalCommercialUserAuthResponse : AopResponse
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 店员在支付宝端内的用户ID
        /// </summary>
        [XmlElement("staff_user_id")]
        public string StaffUserId { get; set; }
    }
}
