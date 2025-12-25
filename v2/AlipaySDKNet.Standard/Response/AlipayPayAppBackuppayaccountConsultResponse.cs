using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayAppBackuppayaccountConsultResponse.
    /// </summary>
    public class AlipayPayAppBackuppayaccountConsultResponse : AopResponse
    {
        /// <summary>
        /// 备用账号脱敏登录号
        /// </summary>
        [XmlElement("hidden_login_id")]
        public string HiddenLoginId { get; set; }

        /// <summary>
        /// 是否开通备用付款账号
        /// </summary>
        [XmlElement("open_same_person")]
        public bool OpenSamePerson { get; set; }
    }
}
