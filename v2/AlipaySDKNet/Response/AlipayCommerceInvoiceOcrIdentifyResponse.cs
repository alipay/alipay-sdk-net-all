using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceInvoiceOcrIdentifyResponse.
    /// </summary>
    public class AlipayCommerceInvoiceOcrIdentifyResponse : AopResponse
    {
        /// <summary>
        /// OCR原始解析结果列表
        /// </summary>
        [XmlArray("raw_data_list")]
        [XmlArrayItem("string")]
        public List<string> RawDataList { get; set; }
    }
}
