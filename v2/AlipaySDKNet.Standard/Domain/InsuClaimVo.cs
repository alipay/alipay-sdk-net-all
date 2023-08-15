using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsuClaimVo Data Structure.
    /// </summary>
    [Serializable]
    public class InsuClaimVo : AopObject
    {
        /// <summary>
        /// accident_date+不唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(无)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlElement("accident_date")]
        public string AccidentDate { get; set; }

        /// <summary>
        /// accident_reason+不唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(无)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlElement("accident_reason")]
        public string AccidentReason { get; set; }

        /// <summary>
        /// attachment_url+不唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(无)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlArray("attachment_url")]
        [XmlArrayItem("string")]
        public List<string> AttachmentUrl { get; set; }

        /// <summary>
        /// claim_attachment_vo+不唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(无)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlElement("claim_attachment_vo")]
        public InsuClaimAttachmentVo ClaimAttachmentVo { get; set; }

        /// <summary>
        /// claim_flag+不唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(无)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlElement("claim_flag")]
        public string ClaimFlag { get; set; }

        /// <summary>
        /// contact_email+不唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(无)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlElement("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// employee_id+唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(无)+员工申请理赔时赋值+特殊说明(无)
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// insurant_birthday+不唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(无)+员工申请理赔+特殊说明(如有)
        /// </summary>
        [XmlElement("insurant_birthday")]
        public string InsurantBirthday { get; set; }

        /// <summary>
        /// insurant_id_code+唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(无)+员工提交理赔数据时赋值+特殊说明(无)
        /// </summary>
        [XmlElement("insurant_id_code")]
        public string InsurantIdCode { get; set; }

        /// <summary>
        /// insurant_id_type+不唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(如有)+员工申请理赔时赋值+特殊说明(如有)
        /// </summary>
        [XmlElement("insurant_id_type")]
        public string InsurantIdType { get; set; }

        /// <summary>
        /// insurant_name+不唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(无)+员工理赔申请时赋值+特殊说明(无)
        /// </summary>
        [XmlElement("insurant_name")]
        public string InsurantName { get; set; }

        /// <summary>
        /// insurant_sex+不唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(有)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlElement("insurant_sex")]
        public string InsurantSex { get; set; }

        /// <summary>
        /// insurant_type+不唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(有)+员工理赔申请时需要选择与主被保人之间的关系+特殊说明(无)
        /// </summary>
        [XmlElement("insurant_type")]
        public string InsurantType { get; set; }

        /// <summary>
        /// is_submit+不唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值([{"value": "0","name": "未提交申请"},{"value": "1","name": "已经提交申请"},{"value": "2","name": "供应商已收到数据"}])+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlElement("is_submit")]
        public long IsSubmit { get; set; }

        /// <summary>
        /// pay_account_bank+不唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(无)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlElement("pay_account_bank")]
        public string PayAccountBank { get; set; }

        /// <summary>
        /// pay_account_no+不唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(无)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlElement("pay_account_no")]
        public string PayAccountNo { get; set; }

        /// <summary>
        /// pay_name+不唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(无)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlElement("pay_name")]
        public string PayName { get; set; }

        /// <summary>
        /// pay_type+不唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(无)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlElement("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// pay_type_code+不唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(无)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlElement("pay_type_code")]
        public string PayTypeCode { get; set; }

        /// <summary>
        /// relate_birth_date+不唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(无)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlElement("relate_birth_date")]
        public string RelateBirthDate { get; set; }

        /// <summary>
        /// relate_insurant_id_code+不唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(无)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlElement("relate_insurant_id_code")]
        public string RelateInsurantIdCode { get; set; }

        /// <summary>
        /// relate_insurant_id_type+不唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(有)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlElement("relate_insurant_id_type")]
        public string RelateInsurantIdType { get; set; }

        /// <summary>
        /// relate_insurant_name+不唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(无)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlElement("relate_insurant_name")]
        public string RelateInsurantName { get; set; }

        /// <summary>
        /// relate_sex+不唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(有)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlElement("relate_sex")]
        public string RelateSex { get; set; }

        /// <summary>
        /// insurant_birthday+不唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(无)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlElement("report_amount")]
        public string ReportAmount { get; set; }

        /// <summary>
        /// report_biz_no+唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(无)+新增理赔时，根据规则生成渠道报案号+特殊说明(无)
        /// </summary>
        [XmlElement("report_biz_no")]
        public string ReportBizNo { get; set; }

        /// <summary>
        /// report_no+唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(无)+供应商同步给商保系统+特殊说明(无)
        /// </summary>
        [XmlElement("report_no")]
        public string ReportNo { get; set; }

        /// <summary>
        /// source+不唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(无)+生成理赔单时，默认赋值+特殊说明(默认值为alishangbao)
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// status+不唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(有)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
