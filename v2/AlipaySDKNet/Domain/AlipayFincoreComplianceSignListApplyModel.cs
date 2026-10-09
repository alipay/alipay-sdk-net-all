using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreComplianceSignListApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreComplianceSignListApplyModel : AopObject
    {
        /// <summary>
        /// 申请人信息
        /// </summary>
        [XmlElement("applicant")]
        public PeopleOpenApiDTO Applicant { get; set; }

        /// <summary>
        /// 审批信息
        /// </summary>
        [XmlElement("approve_info")]
        public SignApproveOpenApiDTO ApproveInfo { get; set; }

        /// <summary>
        /// 签署附件列表，不参与用印，用于辅助用印的文件
        /// </summary>
        [XmlArray("attachments")]
        [XmlArrayItem("sign_file_open_api_d_t_o")]
        public List<SignFileOpenApiDTO> Attachments { get; set; }

        /// <summary>
        /// 业务单据号
        /// </summary>
        [XmlElement("business_id")]
        public string BusinessId { get; set; }

        /// <summary>
        /// 本次签署描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 生效时间
        /// </summary>
        [XmlElement("effect_date")]
        public string EffectDate { get; set; }

        /// <summary>
        /// 生效方式
        /// </summary>
        [XmlElement("effect_type")]
        public string EffectType { get; set; }

        /// <summary>
        /// 员工id
        /// </summary>
        [XmlElement("emp_id")]
        public string EmpId { get; set; }

        /// <summary>
        /// 失效时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 终止方式
        /// </summary>
        [XmlElement("end_type")]
        public string EndType { get; set; }

        /// <summary>
        /// 是否测试，默认非测试
        /// </summary>
        [XmlElement("is_test")]
        public string IsTest { get; set; }

        /// <summary>
        /// 员工姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 其他方签署分组
        /// </summary>
        [XmlArray("other_sign_groups")]
        [XmlArrayItem("sign_party_group_open_api_d_t_o")]
        public List<SignPartyGroupOpenApiDTO> OtherSignGroups { get; set; }

        /// <summary>
        /// 我方签署分组
        /// </summary>
        [XmlElement("our_sign_group")]
        public SignPartyGroupOpenApiDTO OurSignGroup { get; set; }

        /// <summary>
        /// 纸质用印扩展请求，仅纸质用印需要
        /// </summary>
        [XmlElement("paper_seal_ext_request")]
        public PaperSealExtOpenApiRequest PaperSealExtRequest { get; set; }

        /// <summary>
        /// 用印顺序，默认只需我方用印
        /// </summary>
        [XmlElement("seal_order")]
        public string SealOrder { get; set; }

        /// <summary>
        /// 签署文件
        /// </summary>
        [XmlArray("sign_files")]
        [XmlArrayItem("sign_file_open_api_d_t_o")]
        public List<SignFileOpenApiDTO> SignFiles { get; set; }

        /// <summary>
        /// 签署方式
        /// </summary>
        [XmlElement("sign_method")]
        public string SignMethod { get; set; }

        /// <summary>
        /// 系统来源id
        /// </summary>
        [XmlElement("source_system_id")]
        public string SourceSystemId { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }

        /// <summary>
        /// 文件标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
