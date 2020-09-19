using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceOpenRedCreateResponse.
    /// </summary>
    public class AlipayEbppInvoiceOpenRedCreateResponse : AopResponse
    {
        /// <summary>
        /// 发票生成的开票申请流水id，查询开票结果使用改值
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }
    }
}
