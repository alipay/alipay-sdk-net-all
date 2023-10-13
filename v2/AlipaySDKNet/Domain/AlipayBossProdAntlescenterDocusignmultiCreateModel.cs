using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdAntlescenterDocusignmultiCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdAntlescenterDocusignmultiCreateModel : AopObject
    {
        /// <summary>
        /// 申请人工号
        /// </summary>
        [XmlElement("applicant")]
        public string Applicant { get; set; }

        /// <summary>
        /// 申请人真实姓名
        /// </summary>
        [XmlElement("applicant_real_name")]
        public string ApplicantRealName { get; set; }

        /// <summary>
        /// 业务系统申请单号，业务幂等字段，必传
        /// </summary>
        [XmlElement("application_id")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// 申请方系统标识
        /// </summary>
        [XmlElement("application_system")]
        public string ApplicationSystem { get; set; }

        /// <summary>
        /// 申请日期
        /// </summary>
        [XmlElement("application_time")]
        public string ApplicationTime { get; set; }

        /// <summary>
        /// 审批流程信息
        /// </summary>
        [XmlArray("approval_flow_info_list")]
        [XmlArrayItem("approval_flow_info")]
        public List<ApprovalFlowInfo> ApprovalFlowInfoList { get; set; }

        /// <summary>
        /// 签约附件列表，list中为文件id，具有唯一性
        /// </summary>
        [XmlArray("attachement_file_list")]
        [XmlArrayItem("create_e_sign_task_file_v_o")]
        public List<CreateESignTaskFileVO> AttachementFileList { get; set; }

        /// <summary>
        /// 业务线编码
        /// </summary>
        [XmlElement("business_line_code")]
        public string BusinessLineCode { get; set; }

        /// <summary>
        /// 合同id
        /// </summary>
        [XmlElement("contract_id")]
        public string ContractId { get; set; }

        /// <summary>
        /// 合同基本信息
        /// </summary>
        [XmlElement("contract_information")]
        public ContractInformation ContractInformation { get; set; }

        /// <summary>
        /// contractVersion (全数字组成)
        /// </summary>
        [XmlElement("contract_version")]
        public string ContractVersion { get; set; }

        /// <summary>
        /// 合同描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 签署中心：签署受理唯一流水号
        /// </summary>
        [XmlElement("flow_id")]
        public string FlowId { get; set; }

        /// <summary>
        /// 鉴权字符串
        /// </summary>
        [XmlElement("hash_value")]
        public string HashValue { get; set; }

        /// <summary>
        /// 是否测试
        /// </summary>
        [XmlElement("is_test")]
        public string IsTest { get; set; }

        /// <summary>
        /// 签署组件信息
        /// </summary>
        [XmlArray("multi_signer_and_tab_vos_dto_list")]
        [XmlArrayItem("multi_signer_and_tab_vos_d_t_o")]
        public List<MultiSignerAndTabVosDTO> MultiSignerAndTabVosDtoList { get; set; }

        /// <summary>
        /// 区域机房码，电子签约中心不消费，透传
        /// </summary>
        [XmlElement("region_code")]
        public string RegionCode { get; set; }

        /// <summary>
        /// 场景编码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 签约文件列表，list中为文件id，具有唯一性，必传且size>0
        /// </summary>
        [XmlArray("sign_file_list")]
        [XmlArrayItem("create_e_sign_task_file_v_o")]
        public List<CreateESignTaskFileVO> SignFileList { get; set; }

        /// <summary>
        /// 业务系统链接，方便从法务中台跳转
        /// </summary>
        [XmlElement("source_sys_url")]
        public string SourceSysUrl { get; set; }

        /// <summary>
        /// 租户信息
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }

        /// <summary>
        /// IPAY租户，电子签约中心不消费，透传
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
