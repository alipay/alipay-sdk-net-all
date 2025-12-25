using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayAppBackuppayaccountConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayAppBackuppayaccountConsultModel : AopObject
    {
        /// <summary>
        /// 表示需要咨询备用付款账号的uid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 调用来源方
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 支付宝userId，表示需要咨询备用付款账号的uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
