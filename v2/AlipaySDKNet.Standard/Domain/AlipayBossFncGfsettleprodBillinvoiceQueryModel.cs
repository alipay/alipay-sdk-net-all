using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfsettleprodBillinvoiceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfsettleprodBillinvoiceQueryModel : AopObject
    {
        /// <summary>
        /// 申请单聚合id
        /// </summary>
        [XmlElement("apply_relative_id")]
        public string ApplyRelativeId { get; set; }

        /// <summary>
        /// 账单号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 销方角色id
        /// </summary>
        [XmlElement("seller_ip_role_id")]
        public string SellerIpRoleId { get; set; }
    }
}
