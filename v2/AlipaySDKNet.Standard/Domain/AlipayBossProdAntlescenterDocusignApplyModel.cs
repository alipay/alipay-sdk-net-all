using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdAntlescenterDocusignApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdAntlescenterDocusignApplyModel : AopObject
    {
        /// <summary>
        /// 申请人
        /// </summary>
        [XmlElement("applicant")]
        public string Applicant { get; set; }

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
        [XmlArrayItem("approval_flow_info_d_t_o")]
        public List<ApprovalFlowInfoDTO> ApprovalFlowInfoList { get; set; }

        /// <summary>
        /// 跳转至原系统页面查看参数 (全数字组成)
        /// </summary>
        [XmlElement("contract_id")]
        public string ContractId { get; set; }

        /// <summary>
        /// 合同基本信息
        /// </summary>
        [XmlElement("contract_information")]
        public ContractInformationVo ContractInformation { get; set; }

        /// <summary>
        /// 合约版本(全数字组成)
        /// </summary>
        [XmlElement("contract_version")]
        public string ContractVersion { get; set; }

        /// <summary>
        /// 鉴权字符串，必传
        /// </summary>
        [XmlElement("hash_value")]
        public string HashValue { get; set; }

        /// <summary>
        /// 跳转至原系统页面查看参数
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 区域机房码，电子签约中心不消费，透传
        /// </summary>
        [XmlElement("region_code")]
        public string RegionCode { get; set; }

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
        /// IPAY租户，电子签约中心不消费，透传
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
