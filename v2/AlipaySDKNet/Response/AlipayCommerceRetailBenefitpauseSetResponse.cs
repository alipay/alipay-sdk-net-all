using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRetailBenefitpauseSetResponse.
    /// </summary>
    public class AlipayCommerceRetailBenefitpauseSetResponse : AopResponse
    {
        /// <summary>
        /// 如果有副本审核id表示副本修改成功
        /// </summary>
        [XmlElement("copy_edit_id")]
        public string CopyEditId { get; set; }
    }
}
