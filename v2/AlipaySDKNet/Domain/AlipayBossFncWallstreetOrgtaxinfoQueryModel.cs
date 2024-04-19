using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncWallstreetOrgtaxinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncWallstreetOrgtaxinfoQueryModel : AopObject
    {
        /// <summary>
        /// 组织code
        /// </summary>
        [XmlElement("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 组织id
        /// </summary>
        [XmlElement("org_id")]
        public string OrgId { get; set; }

        /// <summary>
        /// 税务编号
        /// </summary>
        [XmlElement("purchaser_tax_no")]
        public string PurchaserTaxNo { get; set; }
    }
}
