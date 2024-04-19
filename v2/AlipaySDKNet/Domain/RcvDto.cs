using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RcvDto Data Structure.
    /// </summary>
    [Serializable]
    public class RcvDto : AopObject
    {
        /// <summary>
        /// 公司
        /// </summary>
        [XmlElement("company")]
        public OuDTO Company { get; set; }

        /// <summary>
        /// 附件号
        /// </summary>
        [XmlElement("credit_note")]
        public string CreditNote { get; set; }

        /// <summary>
        /// 可执行金额/元
        /// </summary>
        [XmlElement("execute_amount")]
        public string ExecuteAmount { get; set; }

        /// <summary>
        /// 验收所需材料(文件服务器对应ID)
        /// </summary>
        [XmlArray("files")]
        [XmlArrayItem("file_d_t_o")]
        public List<FileDTO> Files { get; set; }

        /// <summary>
        /// 审批完成时间
        /// </summary>
        [XmlElement("finish_date")]
        public string FinishDate { get; set; }

        /// <summary>
        /// 流程实例ID
        /// </summary>
        [XmlElement("instance_id")]
        public string InstanceId { get; set; }

        /// <summary>
        /// 是否允许修改
        /// </summary>
        [XmlElement("is_allow_modify")]
        public bool IsAllowModify { get; set; }

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
        /// 接收单详情页面
        /// </summary>
        [XmlElement("rcv_detail_url")]
        public string RcvDetailUrl { get; set; }

        /// <summary>
        /// 接收单头id
        /// </summary>
        [XmlElement("rcv_head_id")]
        public string RcvHeadId { get; set; }

        /// <summary>
        /// 接收单行信息
        /// </summary>
        [XmlArray("rcv_shipment_lines")]
        [XmlArrayItem("rcv_line_result_out_d_t_o")]
        public List<RcvLineResultOutDTO> RcvShipmentLines { get; set; }

        /// <summary>
        /// 接收状态
        /// </summary>
        [XmlElement("rcv_status")]
        public string RcvStatus { get; set; }

        /// <summary>
        /// 接收状态编码
        /// </summary>
        [XmlElement("rcv_status_code")]
        public string RcvStatusCode { get; set; }

        /// <summary>
        /// rcv类型
        /// </summary>
        [XmlElement("rcv_type")]
        public string RcvType { get; set; }

        /// <summary>
        /// 接收单号
        /// </summary>
        [XmlElement("rcv_umber")]
        public string RcvUmber { get; set; }

        /// <summary>
        /// 已接收金额/元
        /// </summary>
        [XmlElement("received_amount")]
        public string ReceivedAmount { get; set; }

        /// <summary>
        /// 接收人
        /// </summary>
        [XmlElement("receiver")]
        public PersonDTO Receiver { get; set; }

        /// <summary>
        /// 供应商
        /// </summary>
        [XmlElement("supplier_dto")]
        public SupplierDTO SupplierDto { get; set; }

        /// <summary>
        /// 审批记录
        /// </summary>
        [XmlElement("workflow_logs")]
        public WorkflowLogDTO WorkflowLogs { get; set; }
    }
}
