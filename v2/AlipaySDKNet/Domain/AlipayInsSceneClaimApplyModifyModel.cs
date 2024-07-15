using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneClaimApplyModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneClaimApplyModifyModel : AopObject
    {
        /// <summary>
        /// 事故发生地址
        /// </summary>
        [XmlElement("accident_address")]
        public string AccidentAddress { get; set; }

        /// <summary>
        /// 事故描述
        /// </summary>
        [XmlElement("accident_desc")]
        public string AccidentDesc { get; set; }

        /// <summary>
        /// 事故时间
        /// </summary>
        [XmlElement("accident_time")]
        public string AccidentTime { get; set; }

        /// <summary>
        /// 事故类型
        /// </summary>
        [XmlElement("accident_type")]
        public string AccidentType { get; set; }

        /// <summary>
        /// 事故详情
        /// </summary>
        [XmlElement("accident_type_detail")]
        public string AccidentTypeDetail { get; set; }

        /// <summary>
        /// 申请报案金额（单位：分）
        /// </summary>
        [XmlElement("apply_amout")]
        public long ApplyAmout { get; set; }

        /// <summary>
        /// 报案更新类型
        /// </summary>
        [XmlElement("attachment_submit_type")]
        public string AttachmentSubmitType { get; set; }

        /// <summary>
        /// 报案材料
        /// </summary>
        [XmlArray("attachments")]
        [XmlArrayItem("ins_open_attachment_d_t_o")]
        public List<InsOpenAttachmentDTO> Attachments { get; set; }

        /// <summary>
        /// 报案业务信息
        /// </summary>
        [XmlElement("claim_report_biz_info")]
        public string ClaimReportBizInfo { get; set; }

        /// <summary>
        /// 报案号，取值来源于前置流程的接口返回
        /// </summary>
        [XmlElement("claim_report_no")]
        public string ClaimReportNo { get; set; }

        /// <summary>
        /// 外部业务单号，传业务的订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 合作商标识，取值由蚂蚁侧提供
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }
    }
}
