using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InputInvoiceBatchModifyOpenApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InputInvoiceBatchModifyOpenApiDTO : AopObject
    {
        /// <summary>
        /// 修改模型
        /// </summary>
        [XmlArray("input_invoice_modify_open_api_dto_list")]
        [XmlArrayItem("input_invoice_modify_open_api_d_t_o")]
        public List<InputInvoiceModifyOpenApiDTO> InputInvoiceModifyOpenApiDtoList { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 平台code
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 请求幂等号
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }
    }
}
