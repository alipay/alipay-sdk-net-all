using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiAuthOrderCloseResponse.
    /// </summary>
    public class AlipayPcreditHuabeiAuthOrderCloseResponse : AopResponse
    {
        /// <summary>
        /// 支付宝侧花呗冻结解冻操作单据id
        /// </summary>
        [XmlElement("auth_opt_id")]
        public string AuthOptId { get; set; }

        /// <summary>
        /// 商户本次操作的请求流水号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
