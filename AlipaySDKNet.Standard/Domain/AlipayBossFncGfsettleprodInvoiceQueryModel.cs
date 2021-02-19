using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfsettleprodInvoiceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfsettleprodInvoiceQueryModel : AopObject
    {
        /// <summary>
        /// 开票号
        /// </summary>
        [XmlElement("kp_no")]
        public string KpNo { get; set; }

        /// <summary>
        /// 蚂蚁供应商2088账号PID
        /// </summary>
        [XmlArray("seller_ip_role_ids")]
        [XmlArrayItem("string")]
        public List<string> SellerIpRoleIds { get; set; }
    }
}
