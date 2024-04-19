using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPeZmgoPreConsultResponse.
    /// </summary>
    public class ZhimaCreditPeZmgoPreConsultResponse : AopResponse
    {
        /// <summary>
        /// 是否准入
        /// </summary>
        [XmlElement("admittance")]
        public bool Admittance { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 开放ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }
    }
}
