using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiServindustryReservationShopBindResponse.
    /// </summary>
    public class KoubeiServindustryReservationShopBindResponse : AopResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 业务是否 成功true，失败false
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
