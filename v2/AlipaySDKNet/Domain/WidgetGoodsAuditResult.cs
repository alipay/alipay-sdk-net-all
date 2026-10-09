using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WidgetGoodsAuditResult Data Structure.
    /// </summary>
    [Serializable]
    public class WidgetGoodsAuditResult : AopObject
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
        /// 商品ID
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品所属的小程序ID
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
        /// 小部件ID
        /// </summary>
        [XmlElement("widget_id")]
        public string WidgetId { get; set; }
    }
}
