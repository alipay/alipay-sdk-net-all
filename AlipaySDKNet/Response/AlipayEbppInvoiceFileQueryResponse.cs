using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceFileQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceFileQueryResponse : AopResponse
    {
        /// <summary>
        /// 发票文件内容,需要先base64解码，获取原始byte[]类型文件流
        /// </summary>
        [XmlElement("invoice_file_content")]
        public string InvoiceFileContent { get; set; }
    }
}
