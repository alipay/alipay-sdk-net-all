using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfsettleprodInvoicetaxlossQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfsettleprodInvoicetaxlossQueryModel : AopObject
    {
        /// <summary>
        /// 账单号
        /// </summary>
        [XmlElement("bill_nos")]
        public string BillNos { get; set; }

        /// <summary>
        /// PID
        /// </summary>
        [XmlElement("settle_ip_role_id")]
        public string SettleIpRoleId { get; set; }
    }
}
