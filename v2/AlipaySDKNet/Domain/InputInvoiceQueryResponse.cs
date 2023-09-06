using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InputInvoiceQueryResponse Data Structure.
    /// </summary>
    [Serializable]
    public class InputInvoiceQueryResponse : AopObject
    {
        /// <summary>
        /// 发票数据
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("input_invoice_open_api_d_t_o")]
        public List<InputInvoiceOpenApiDTO> Data { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("response_code")]
        public string ResponseCode { get; set; }

        /// <summary>
        /// 信息
        /// </summary>
        [XmlElement("response_msg")]
        public string ResponseMsg { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("succeeded")]
        public bool Succeeded { get; set; }
    }
}
