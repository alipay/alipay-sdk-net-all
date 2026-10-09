using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RcvCreateDto Data Structure.
    /// </summary>
    [Serializable]
    public class RcvCreateDto : AopObject
    {
        /// <summary>
        /// 审批流需要去重的人员
        /// </summary>
        [XmlElement("duplicate_approver")]
        public RcvApproverDto DuplicateApprover { get; set; }

        /// <summary>
        /// 验收所需材料
        /// </summary>
        [XmlArray("files")]
        [XmlArrayItem("file_d_t_o")]
        public List<FileDTO> Files { get; set; }

        /// <summary>
        /// 来源系统
        /// </summary>
        [XmlElement("interface_source_code")]
        public string InterfaceSourceCode { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        [XmlElement("po_number")]
        public string PoNumber { get; set; }

        /// <summary>
        /// 接收说明
        /// </summary>
        [XmlElement("rcv_description")]
        public string RcvDescription { get; set; }

        /// <summary>
        /// 接单收号
        /// </summary>
        [XmlElement("rcv_number")]
        public string RcvNumber { get; set; }

        /// <summary>
        /// 接收单行信息
        /// </summary>
        [XmlArray("rcv_shipment_lines")]
        [XmlArrayItem("rcv_line_dto")]
        public List<RcvLineDto> RcvShipmentLines { get; set; }

        /// <summary>
        /// 来源系统单据号
        /// </summary>
        [XmlArray("source_bill_nos")]
        [XmlArrayItem("string")]
        public List<string> SourceBillNos { get; set; }

        /// <summary>
        /// 来源单据
        /// </summary>
        [XmlArray("source_bills")]
        [XmlArrayItem("link_d_t_o")]
        public List<LinkDTO> SourceBills { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 唯一校验ID
        /// </summary>
        [XmlElement("unique_id")]
        public string UniqueId { get; set; }
    }
}
