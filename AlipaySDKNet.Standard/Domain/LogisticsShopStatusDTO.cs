using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LogisticsShopStatusDTO Data Structure.
    /// </summary>
    [Serializable]
    public class LogisticsShopStatusDTO : AopObject
    {
        /// <summary>
        /// 商家在配送公司的账户的审核说明.
        /// </summary>
        [XmlElement("audit_desc")]
        public string AuditDesc { get; set; }

        /// <summary>
        /// 配送公司物流编码。
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 配送公司名称。
        /// </summary>
        [XmlElement("logistics_name")]
        public string LogisticsName { get; set; }

        /// <summary>
        /// 门店状态，AUDITING:审核中，AUDIT_REJECT:审核驳回，VALID:已生效，UPDATING:更新中
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
