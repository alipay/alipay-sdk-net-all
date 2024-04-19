using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncWallstreetRcvbankaccountinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncWallstreetRcvbankaccountinfoQueryModel : AopObject
    {
        /// <summary>
        /// 币种编码
        /// </summary>
        [XmlElement("currency_code")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// 组织ID
        /// </summary>
        [XmlElement("org_id")]
        public long OrgId { get; set; }
    }
}
