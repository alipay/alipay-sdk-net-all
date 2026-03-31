using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRetailBenefitpublishSetResponse.
    /// </summary>
    public class AlipayCommerceRetailBenefitpublishSetResponse : AopResponse
    {
        /// <summary>
        /// 如果有表示是副本修改成功，没有则是正本修改chen
        /// </summary>
        [XmlElement("copy_edit_id")]
        public string CopyEditId { get; set; }
    }
}
