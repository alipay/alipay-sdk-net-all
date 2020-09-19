using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditmerchantProductorderTransferResponse.
    /// </summary>
    public class AlipayPcreditHuabeiPcreditmerchantProductorderTransferResponse : AopResponse
    {
        /// <summary>
        /// 业务成功标志
        /// </summary>
        [XmlElement("biz_success")]
        public bool BizSuccess { get; set; }

        /// <summary>
        /// 订购ID
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 业务错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息返回
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }
    }
}
