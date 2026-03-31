using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRetailBenefitSaveResponse.
    /// </summary>
    public class AlipayCommerceRetailBenefitSaveResponse : AopResponse
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 副本审核id
        /// </summary>
        [XmlElement("copy_edit_id")]
        public string CopyEditId { get; set; }
    }
}
