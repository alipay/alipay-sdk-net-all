using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceSpecificsDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceSpecificsDTO : AopObject
    {
        /// <summary>
        /// 发票到票DTO列表
        /// </summary>
        [XmlArray("invoice_arrival_dtos")]
        [XmlArrayItem("invoice_arrival_d_t_o")]
        public List<InvoiceArrivalDTO> InvoiceArrivalDtos { get; set; }

        /// <summary>
        /// 发票DTO
        /// </summary>
        [XmlElement("invoice_dto")]
        public InvoiceDTO InvoiceDto { get; set; }
    }
}
