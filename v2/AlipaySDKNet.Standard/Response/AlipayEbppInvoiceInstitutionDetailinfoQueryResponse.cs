using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceInstitutionDetailinfoQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceInstitutionDetailinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 若适用范围为EMPLOYEE_ALL，则表示制度对企业下全员生效，owner_id_list不返回；若适配范围为EMPLOYEE_SELECT，owner_id_list返回员工对应的id信息，返回的id类型通过owner_type区分；若适配范围为EMPLOYEE_DEPARTMENT，则表示对指定的部门生效，返回owner_id_list为部门id列表
        /// </summary>
        [XmlElement("adapter_type")]
        public string AdapterType { get; set; }

        /// <summary>
        /// 费控咨询模式
        /// </summary>
        [XmlElement("consult_mode")]
        public string ConsultMode { get; set; }

        /// <summary>
        /// 制度启用停用状态
        /// </summary>
        [XmlElement("effective")]
        public string Effective { get; set; }

        /// <summary>
        /// 制度生效结束时间
        /// </summary>
        [XmlElement("effective_end_date")]
        public string EffectiveEndDate { get; set; }

        /// <summary>
        /// 制度生效起始时间
        /// </summary>
        [XmlElement("effective_start_date")]
        public string EffectiveStartDate { get; set; }

        /// <summary>
        /// 费用类型
        /// </summary>
        [XmlElement("expense_type")]
        public string ExpenseType { get; set; }

        /// <summary>
        /// 制度描述
        /// </summary>
        [XmlElement("institution_desc")]
        public string InstitutionDesc { get; set; }

        /// <summary>
        /// 制度id
        /// </summary>
        [XmlElement("institution_id")]
        public string InstitutionId { get; set; }

        /// <summary>
        /// 制度名称
        /// </summary>
        [XmlElement("institution_name")]
        public string InstitutionName { get; set; }

        /// <summary>
        /// 发放规则信息列表
        /// </summary>
        [XmlArray("issue_rule_info_list")]
        [XmlArrayItem("issue_rule_info")]
        public List<IssueRuleInfo> IssueRuleInfoList { get; set; }

        /// <summary>
        /// 外部唯一标识
        /// </summary>
        [XmlElement("outer_source_id")]
        public string OuterSourceId { get; set; }

        /// <summary>
        /// 适配id列表
        /// </summary>
        [XmlArray("owner_id_list")]
        [XmlArrayItem("string")]
        public List<string> OwnerIdList { get; set; }

        /// <summary>
        /// 适配开放id列表
        /// </summary>
        [XmlArray("owner_open_id_list")]
        [XmlArrayItem("string")]
        public List<string> OwnerOpenIdList { get; set; }

        /// <summary>
        /// 因公场景
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 使用规则列表
        /// </summary>
        [XmlArray("standard_info_detail_list")]
        [XmlArrayItem("standard_info")]
        public List<StandardInfo> StandardInfoDetailList { get; set; }

        /// <summary>
        /// 使用规则列表（已废弃）
        /// </summary>
        [XmlElement("standard_info_list")]
        public StandardInfo StandardInfoList { get; set; }
    }
}
