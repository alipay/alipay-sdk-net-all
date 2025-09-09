using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAgentVersionDetailQueryResponse.
    /// </summary>
    public class AlipayOpenAgentVersionDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 智能体应用logo图标
        /// </summary>
        [XmlElement("app_logo")]
        public string AppLogo { get; set; }

        /// <summary>
        /// 智能体应用名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 智能体开发包版本号
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 审核驳回原因
        /// </summary>
        [XmlElement("audit_reason")]
        public string AuditReason { get; set; }

        /// <summary>
        /// 智能体投放的客户端类型。支持如下客户端：支小宝、web服务
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 版本提审时间
        /// </summary>
        [XmlElement("gmt_apply_audit")]
        public string GmtApplyAudit { get; set; }

        /// <summary>
        /// 审核结束时间
        /// </summary>
        [XmlElement("gmt_audit_end")]
        public string GmtAuditEnd { get; set; }

        /// <summary>
        /// 版本创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 版本下架时间
        /// </summary>
        [XmlElement("gmt_offline")]
        public string GmtOffline { get; set; }

        /// <summary>
        /// 版本上架时间
        /// </summary>
        [XmlElement("gmt_online")]
        public string GmtOnline { get; set; }

        /// <summary>
        /// 版本状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 智能体版本备注
        /// </summary>
        [XmlElement("version_desc")]
        public string VersionDesc { get; set; }
    }
}
