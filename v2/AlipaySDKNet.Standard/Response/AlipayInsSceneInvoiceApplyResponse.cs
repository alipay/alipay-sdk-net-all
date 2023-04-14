using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneInvoiceApplyResponse.
    /// </summary>
    public class AlipayInsSceneInvoiceApplyResponse : AopResponse
    {
        /// <summary>
        /// 发票申请单号
        /// </summary>
        [XmlElement("invoice_apply_no")]
        public string InvoiceApplyNo { get; set; }

        /// <summary>
        /// 商户生成的发票申请请求单号【幂等字段】
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
