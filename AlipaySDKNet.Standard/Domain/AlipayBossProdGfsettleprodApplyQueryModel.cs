using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdGfsettleprodApplyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdGfsettleprodApplyQueryModel : AopObject
    {
        /// <summary>
        /// 合约号，等同于集采PO号
        /// </summary>
        [XmlElement("arrangement_no")]
        public string ArrangementNo { get; set; }

        /// <summary>
        /// 供应商支付宝2088账号
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }
    }
}
