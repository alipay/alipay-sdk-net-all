using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditmerchantProductorderSignResponse.
    /// </summary>
    public class AlipayPcreditHuabeiPcreditmerchantProductorderSignResponse : AopResponse
    {
        /// <summary>
        /// 业务是否成功字段
        /// </summary>
        [XmlElement("biz_success")]
        public bool BizSuccess { get; set; }

        /// <summary>
        /// 订购单号
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 业务错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 业务错误细腻
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }
    }
}
