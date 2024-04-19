using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfsmartpayInvoiceserviceCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfsmartpayInvoiceserviceCreateModel : AopObject
    {
        /// <summary>
        /// 发票录入人
        /// </summary>
        [XmlElement("entry_by")]
        public string EntryBy { get; set; }

        /// <summary>
        /// 指定的到票关系列表
        /// </summary>
        [XmlArray("invoice_specifics_dtos")]
        [XmlArrayItem("invoice_specifics_d_t_o")]
        public List<InvoiceSpecificsDTO> InvoiceSpecificsDtos { get; set; }

        /// <summary>
        /// 是否按批输入
        /// </summary>
        [XmlElement("is_batch")]
        public bool IsBatch { get; set; }

        /// <summary>
        /// 影子标记
        /// </summary>
        [XmlElement("test_mode")]
        public bool TestMode { get; set; }
    }
}
