using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFincoreComplianceCrossborderMerchantBatchqueryResponse.
    /// </summary>
    public class AlipayFincoreComplianceCrossborderMerchantBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 处理结果文字说明
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// out_biz_no
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
