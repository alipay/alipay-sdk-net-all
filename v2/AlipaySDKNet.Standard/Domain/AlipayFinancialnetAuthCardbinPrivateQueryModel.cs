using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFinancialnetAuthCardbinPrivateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinancialnetAuthCardbinPrivateQueryModel : AopObject
    {
        /// <summary>
        /// 卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 机构ID
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }
    }
}
