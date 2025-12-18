using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppItemPremiumQueryResponse.
    /// </summary>
    public class AlipayOpenAppItemPremiumQueryResponse : AopResponse
    {
        /// <summary>
        /// 审核状态，包含：审核中（AUDITING）、审核通过（ENABLED）、审核驳回（REJECTED）、审核撤销（CANCELED）、已暂停（SUSPEND）、已终止（TERMINATED）
        /// </summary>
        [XmlElement("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }
    }
}
