using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsuClaimRecordVo Data Structure.
    /// </summary>
    [Serializable]
    public class InsuClaimRecordVo : AopObject
    {
        /// <summary>
        /// accident_date+不唯一+供应商同步理赔报案进度+枚举值(无)+用户申请理赔时赋值+特殊说明(无)
        /// </summary>
        [XmlElement("accident_date")]
        public string AccidentDate { get; set; }

        /// <summary>
        /// accident_reason+不唯一+供应商同步理赔报案进度+枚举值(无)+供应商同步时赋值+特殊说明(无)
        /// </summary>
        [XmlElement("accident_reason")]
        public string AccidentReason { get; set; }

        /// <summary>
        /// claim_no+不唯一+供应商同步理赔报案进度+枚举值(无)+用户申请理赔时赋值+特殊说明(无)
        /// </summary>
        [XmlElement("claim_no")]
        public string ClaimNo { get; set; }

        /// <summary>
        /// close_date+不唯一+供应商同步理赔报案进度+枚举值(无)+供应商同步时赋值+特殊说明(无)
        /// </summary>
        [XmlElement("close_date")]
        public string CloseDate { get; set; }

        /// <summary>
        /// err_code+不唯一+供应商同步理赔报案进度+枚举值(无)+供应商同步时赋值+特殊说明(无)
        /// </summary>
        [XmlElement("err_code")]
        public string ErrCode { get; set; }

        /// <summary>
        /// err_msg+不唯一+供应商同步理赔报案进度+枚举值(无)+供应商同步时赋值+特殊说明(无)
        /// </summary>
        [XmlElement("err_msg")]
        public string ErrMsg { get; set; }

        /// <summary>
        /// fallback_date+不唯一+供应商同步理赔报案进度+枚举值(无)+供应商同步时赋值+特殊说明(无)
        /// </summary>
        [XmlElement("fallback_date")]
        public string FallbackDate { get; set; }

        /// <summary>
        /// fallback_reason+不唯一+供应商同步理赔报案进度+枚举值(无)+供应商同步时赋值+特殊说明(无)
        /// </summary>
        [XmlElement("fallback_reason")]
        public string FallbackReason { get; set; }

        /// <summary>
        /// insurant_birthday+不唯一+供应商同步理赔报案进度+枚举值(无)+员工申请理赔+特殊说明(如有)
        /// </summary>
        [XmlElement("insurant_birthday")]
        public string InsurantBirthday { get; set; }

        /// <summary>
        /// insurant_id_code+唯一+供应商同步理赔报案进度+枚举值(无)+员工提交理赔数据时赋值+特殊说明(无)
        /// </summary>
        [XmlElement("insurant_id_code")]
        public string InsurantIdCode { get; set; }

        /// <summary>
        /// insurant_id_type+不唯一+供应商同步理赔报案进度+枚举值(如有)+员工申请理赔时赋值+特殊说明(如有)
        /// </summary>
        [XmlElement("insurant_id_type")]
        public string InsurantIdType { get; set; }

        /// <summary>
        /// insurant_name+不唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(无)+员工理赔申请时赋值+特殊说明(无)
        /// </summary>
        [XmlElement("insurant_name")]
        public string InsurantName { get; set; }

        /// <summary>
        /// insurant_sex+不唯一+供应商同步理赔报案进度+枚举值(有)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlElement("insurant_sex")]
        public string InsurantSex { get; set; }

        /// <summary>
        /// insurant_type+不唯一+供应商同步理赔报案进度+枚举值(有)+员工理赔申请时需要选择与主被保人之间的关系+特殊说明(无)
        /// </summary>
        [XmlElement("insurant_type")]
        public string InsurantType { get; set; }

        /// <summary>
        /// insure_name+不唯一+供应商同步理赔报案进度+枚举值(无)+供应商同步时赋值+特殊说明(无)
        /// </summary>
        [XmlElement("insure_name")]
        public string InsureName { get; set; }

        /// <summary>
        /// is_submit+不唯一+供应商同步理赔报案进度+枚举值([{"value": "0","name": "未提交申请"},{"value": "1","name": "已经提交申请"},{"value": "2","name": "供应商已收到数据"}])+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlElement("is_submit")]
        public long IsSubmit { get; set; }

        /// <summary>
        /// notice_download_url+不唯一+供应商同步理赔报案进度+枚举值(无)+供应商同步时赋值+特殊说明(无)
        /// </summary>
        [XmlElement("notice_download_url")]
        public string NoticeDownloadUrl { get; set; }

        /// <summary>
        /// paid_amount+不唯一+供应商同步理赔报案进度+枚举值(无)+供应商同步时赋值+特殊说明(无)
        /// </summary>
        [XmlElement("paid_amount")]
        public string PaidAmount { get; set; }

        /// <summary>
        /// refuse_mark+不唯一+供应商同步理赔报案进度+枚举值(无)+供应商同步时赋值+特殊说明(无)
        /// </summary>
        [XmlElement("refuse_mark")]
        public string RefuseMark { get; set; }

        /// <summary>
        /// refuse_reason+不唯一+供应商同步理赔报案进度+枚举值(无)+供应商同步时赋值+特殊说明(无)
        /// </summary>
        [XmlElement("refuse_reason")]
        public string RefuseReason { get; set; }

        /// <summary>
        /// register_date+不唯一+供应商同步理赔报案进度+枚举值(无)+用户申请理赔时赋值+特殊说明(无)
        /// </summary>
        [XmlElement("register_date")]
        public string RegisterDate { get; set; }

        /// <summary>
        /// relate_birth_date+不唯一+供应商查询未提交给理赔公司的，理赔状态为进行中的理赔报案数据+枚举值(无)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlElement("relate_birth_date")]
        public string RelateBirthDate { get; set; }

        /// <summary>
        /// relate_insurant_id_code+不唯一+供应商同步理赔报案进度+枚举值(无)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlElement("relate_insurant_id_code")]
        public string RelateInsurantIdCode { get; set; }

        /// <summary>
        /// relate_insurant_id_type+不唯一+供应商同步理赔报案进度+枚举值(有)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlElement("relate_insurant_id_type")]
        public string RelateInsurantIdType { get; set; }

        /// <summary>
        /// relate_insurant_name+不唯一+供应商同步理赔报案进度+枚举值(无)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlElement("relate_insurant_name")]
        public string RelateInsurantName { get; set; }

        /// <summary>
        /// relate_sex+不唯一+供应商同步理赔报案进度+枚举值(有)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlElement("relate_sex")]
        public string RelateSex { get; set; }

        /// <summary>
        /// report_biz_no+唯一+供应商同步理赔报案进度+枚举值(无)+新增理赔时，根据规则生成渠道报案号+特殊说明(无)
        /// </summary>
        [XmlElement("report_biz_no")]
        public string ReportBizNo { get; set; }

        /// <summary>
        /// report_date+不唯一+供应商同步理赔报案进度+枚举值(无)+用户申请理赔时赋值+特殊说明(无)
        /// </summary>
        [XmlElement("report_date")]
        public string ReportDate { get; set; }

        /// <summary>
        /// report_no+唯一+供应商同步理赔报案进度+枚举值(无)+供应商同步给商保系统+特殊说明(无)
        /// </summary>
        [XmlElement("report_no")]
        public string ReportNo { get; set; }

        /// <summary>
        /// source+不唯一+供应商同步理赔报案进度+枚举值(无)+生成理赔单时，默认赋值+特殊说明(默认值为alishangbao)
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// status+不唯一+供应商同步理赔报案进度+枚举值(有)+员工申请理赔+特殊说明(无)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// supplier_id+不唯一+供应商同步理赔报案进度+枚举值(无)+用户申请理赔时赋值+特殊说明(无)
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }

        /// <summary>
        /// method+不唯一+供应商同步理赔报案进度+枚举值(无)+供应商根据同步类型赋值+特殊说明(无)
        /// </summary>
        [XmlElement("sync_method")]
        public string SyncMethod { get; set; }
    }
}
