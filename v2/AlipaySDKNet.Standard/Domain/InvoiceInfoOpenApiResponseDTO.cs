using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceInfoOpenApiResponseDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceInfoOpenApiResponseDTO : AopObject
    {
        /// <summary>
        /// 开票信息
        /// </summary>
        [XmlArray("invoice_info_open_api_dto_list")]
        [XmlArrayItem("invoice_info_open_api_d_t_o")]
        public List<InvoiceInfoOpenApiDTO> InvoiceInfoOpenApiDtoList { get; set; }
    }
}
