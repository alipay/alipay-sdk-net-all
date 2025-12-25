using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalAqUsersimpleQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalAqUsersimpleQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户当前2088
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 用户当前2089
        /// </summary>
        [XmlElement("aq_user_id")]
        public string AqUserId { get; set; }
    }
}
