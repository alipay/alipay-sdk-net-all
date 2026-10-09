using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceDspcreativeBatchqueryResponse.
    /// </summary>
    public class AlipayDataDataserviceDspcreativeBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 创意审核结果列表
        /// </summary>
        [XmlArray("creative_audit_result")]
        [XmlArrayItem("dsp_creative_audit_result")]
        public List<DspCreativeAuditResult> CreativeAuditResult { get; set; }
    }
}
