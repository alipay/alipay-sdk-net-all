using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceResultGetResponse.
    /// </summary>
    public class AlipayEbppInvoiceResultGetResponse : AopResponse
    {
        /// <summary>
        /// 发票详细信息 开票返回结果数据列表。 根据platform_tid查询时，可返回多条开票结果数据。 根据apply_id查询时，返回数组中只会有一条数据
        /// </summary>
        [XmlArray("invoice_result_list")]
        [XmlArrayItem("ant_invoice_result")]
        public List<AntInvoiceResult> InvoiceResultList { get; set; }
    }
}
