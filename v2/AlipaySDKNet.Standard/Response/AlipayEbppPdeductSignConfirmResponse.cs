using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppPdeductSignConfirmResponse.
    /// </summary>
    public class AlipayEbppPdeductSignConfirmResponse : AopResponse
    {
        /// <summary>
        /// 支付宝代扣协议ID
        /// </summary>
        [XmlElement("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 支付宝是否签约成功，T：成功，F:失败
        /// </summary>
        [XmlElement("alipay_sign_status")]
        public string AlipaySignStatus { get; set; }

        /// <summary>
        /// 业务处理结果，默认9999
        /// </summary>
        [XmlElement("rtn_flag")]
        public string RtnFlag { get; set; }

        /// <summary>
        /// 签约处理结果文字信息，一般返回成功或失败原因
        /// </summary>
        [XmlElement("rtn_msg")]
        public string RtnMsg { get; set; }

        /// <summary>
        /// 流水号，用于交易跟踪，无业务意义
        /// </summary>
        [XmlElement("serial_no")]
        public string SerialNo { get; set; }
    }
}
