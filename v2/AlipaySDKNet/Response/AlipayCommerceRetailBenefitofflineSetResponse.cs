using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRetailBenefitofflineSetResponse.
    /// </summary>
    public class AlipayCommerceRetailBenefitofflineSetResponse : AopResponse
    {
        /// <summary>
        /// 副本修改id
        /// </summary>
        [XmlElement("copy_edit_id")]
        public string CopyEditId { get; set; }
    }
}
