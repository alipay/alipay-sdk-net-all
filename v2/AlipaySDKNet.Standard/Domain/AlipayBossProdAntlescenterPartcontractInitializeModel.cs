using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdAntlescenterPartcontractInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdAntlescenterPartcontractInitializeModel : AopObject
    {
        /// <summary>
        /// 系统来源
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 申请人姓名
        /// </summary>
        [XmlElement("applicant")]
        public string Applicant { get; set; }

        /// <summary>
        /// 申请人部门
        /// </summary>
        [XmlElement("applicant_sector")]
        public string ApplicantSector { get; set; }

        /// <summary>
        /// 申请时间
        /// </summary>
        [XmlElement("application_time")]
        public string ApplicationTime { get; set; }

        /// <summary>
        /// 申请类型
        /// </summary>
        [XmlElement("application_type")]
        public string ApplicationType { get; set; }

        /// <summary>
        /// 归档编号
        /// </summary>
        [XmlElement("archive_no")]
        public string ArchiveNo { get; set; }

        /// <summary>
        /// 归档时间
        /// </summary>
        [XmlElement("archive_time")]
        public string ArchiveTime { get; set; }

        /// <summary>
        /// 合同名称
        /// </summary>
        [XmlElement("contract_name")]
        public string ContractName { get; set; }

        /// <summary>
        /// 合同编号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 合同标签
        /// </summary>
        [XmlElement("contract_tag")]
        public string ContractTag { get; set; }

        /// <summary>
        /// 生效结束时间
        /// </summary>
        [XmlElement("effect_end_time")]
        public string EffectEndTime { get; set; }

        /// <summary>
        /// 生效开始时间
        /// </summary>
        [XmlElement("effect_start_time")]
        public string EffectStartTime { get; set; }

        /// <summary>
        /// 期望完成时间
        /// </summary>
        [XmlElement("expect_time")]
        public string ExpectTime { get; set; }

        /// <summary>
        /// 文件编号
        /// </summary>
        [XmlElement("file_no")]
        public string FileNo { get; set; }

        /// <summary>
        /// 操作人花名
        /// </summary>
        [XmlElement("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        [XmlElement("operator_time")]
        public string OperatorTime { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [XmlElement("operator_type")]
        public string OperatorType { get; set; }

        /// <summary>
        /// 原始合同附件，未用印
        /// </summary>
        [XmlArray("ori_attachment_file_addr")]
        [XmlArrayItem("antlescenter_file_d_t_o")]
        public List<AntlescenterFileDTO> OriAttachmentFileAddr { get; set; }

        /// <summary>
        /// 原始合同文件，未用印
        /// </summary>
        [XmlArray("ori_contract_file_addr")]
        [XmlArrayItem("antlescenter_file_d_t_o")]
        public List<AntlescenterFileDTO> OriContractFileAddr { get; set; }

        /// <summary>
        /// 他方公司名称
        /// </summary>
        [XmlElement("other_company")]
        public string OtherCompany { get; set; }

        /// <summary>
        /// 我方公司名称
        /// </summary>
        [XmlElement("our_company")]
        public string OurCompany { get; set; }

        /// <summary>
        /// 流程详细信息
        /// </summary>
        [XmlElement("process_d_t_o")]
        public AntlescenterProcessDTO ProcessDTO { get; set; }

        /// <summary>
        /// 审批所在业务系统
        /// </summary>
        [XmlElement("process_source")]
        public string ProcessSource { get; set; }

        /// <summary>
        /// 操作人真实姓名
        /// </summary>
        [XmlElement("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 用印顺序
        /// </summary>
        [XmlElement("seal_order")]
        public string SealOrder { get; set; }

        /// <summary>
        /// 用印方式
        /// </summary>
        [XmlElement("seal_type")]
        public string SealType { get; set; }

        /// <summary>
        /// 签署方式类型
        /// </summary>
        [XmlElement("sign_task_type")]
        public string SignTaskType { get; set; }

        /// <summary>
        /// 源系统id
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 业务系统工单号
        /// </summary>
        [XmlElement("source_no")]
        public string SourceNo { get; set; }

        /// <summary>
        /// 源系统url
        /// </summary>
        [XmlElement("source_url")]
        public string SourceUrl { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }

        /// <summary>
        /// 操作人工号
        /// </summary>
        [XmlElement("work_no")]
        public string WorkNo { get; set; }
    }
}
