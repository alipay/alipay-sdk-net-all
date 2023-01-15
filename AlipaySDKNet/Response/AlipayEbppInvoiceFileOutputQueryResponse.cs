using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceFileOutputQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceFileOutputQueryResponse : AopResponse
    {
        /// <summary>
        /// 发票文件类型pdf或ofd
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 发票文件内容,需要先base64解码，获取原始byte[]类型文件流
        /// </summary>
        [XmlElement("invoice_file_content")]
        public string InvoiceFileContent { get; set; }
    }
}
