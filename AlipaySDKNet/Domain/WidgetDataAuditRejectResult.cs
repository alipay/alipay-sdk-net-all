using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WidgetDataAuditRejectResult Data Structure.
    /// </summary>
    [Serializable]
    public class WidgetDataAuditRejectResult : AopObject
    {
        /// <summary>
        /// 审核的备注
        /// </summary>
        [XmlElement("audit_memo")]
        public string AuditMemo { get; set; }

        /// <summary>
        /// 审核结果，PASS:审核通过，REJECT:审核驳回
        /// </summary>
        [XmlElement("audit_result")]
        public string AuditResult { get; set; }

        /// <summary>
        /// 数据ID
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 审核不通过的相关属性
        /// </summary>
        [XmlArray("reject_field_list")]
        [XmlArrayItem("string")]
        public List<string> RejectFieldList { get; set; }

        /// <summary>
        /// 小程序橱窗ID
        /// </summary>
        [XmlElement("widget_id")]
        public string WidgetId { get; set; }
    }
}
