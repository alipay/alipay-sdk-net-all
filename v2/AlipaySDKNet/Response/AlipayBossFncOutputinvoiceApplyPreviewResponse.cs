using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncOutputinvoiceApplyPreviewResponse.
    /// </summary>
    public class AlipayBossFncOutputinvoiceApplyPreviewResponse : AopResponse
    {
        /// <summary>
        /// openApi预览发票混合信息
        /// </summary>
        [XmlElement("result_set")]
        public OpenApiInvoiceMixInfoVO ResultSet { get; set; }
    }
}
