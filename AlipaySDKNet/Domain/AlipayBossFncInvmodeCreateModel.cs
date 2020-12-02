using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncInvmodeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncInvmodeCreateModel : AopObject
    {
        /// <summary>
        /// 合同id
        /// </summary>
        [XmlElement("ar_no")]
        public string ArNo { get; set; }

        /// <summary>
        /// 所属ou
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 开票模式 01：实收开票（先款后票） 02：应收开票（先票后款）
        /// </summary>
        [XmlElement("invoice_mode")]
        public string InvoiceMode { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }
    }
}
