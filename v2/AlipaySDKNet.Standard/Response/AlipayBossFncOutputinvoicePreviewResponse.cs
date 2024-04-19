using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncOutputinvoicePreviewResponse.
    /// </summary>
    public class AlipayBossFncOutputinvoicePreviewResponse : AopResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlArray("result_set")]
        [XmlArrayItem("open_api_output_invoice_v_o")]
        public List<OpenApiOutputInvoiceVO> ResultSet { get; set; }
    }
}
