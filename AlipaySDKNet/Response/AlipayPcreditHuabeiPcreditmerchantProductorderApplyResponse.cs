using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditmerchantProductorderApplyResponse.
    /// </summary>
    public class AlipayPcreditHuabeiPcreditmerchantProductorderApplyResponse : AopResponse
    {
        /// <summary>
        /// 业务成功标志
        /// </summary>
        [XmlElement("biz_success")]
        public bool BizSuccess { get; set; }

        /// <summary>
        /// 订购编码
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 业务错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 业务错误描述
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }
    }
}
