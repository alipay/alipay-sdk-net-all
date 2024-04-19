using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundBailOperationDepositCreateResponse.
    /// </summary>
    public class AlipayFundBailOperationDepositCreateResponse : AopResponse
    {
        /// <summary>
        /// 保证金协议号
        /// </summary>
        [XmlElement("auth_no")]
        public string AuthNo { get; set; }

        /// <summary>
        /// 错误码,当result_code为FAIL时，对应的错误码
        /// </summary>
        [XmlElement("biz_error")]
        public string BizError { get; set; }

        /// <summary>
        /// 操作创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 支付宝资金操作流水号
        /// </summary>
        [XmlElement("operation_id")]
        public string OperationId { get; set; }

        /// <summary>
        /// 商户请求流水号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 处理结果码，代表创单是否成功。
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 请求失败时，返回的错误描述
        /// </summary>
        [XmlElement("result_message")]
        public string ResultMessage { get; set; }
    }
}
