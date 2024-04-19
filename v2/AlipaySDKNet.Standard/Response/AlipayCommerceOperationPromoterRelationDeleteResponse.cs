using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationPromoterRelationDeleteResponse.
    /// </summary>
    public class AlipayCommerceOperationPromoterRelationDeleteResponse : AopResponse
    {
        /// <summary>
        /// 门店推广员解除绑定处理结果
        /// </summary>
        [XmlElement("promoter_delete_result")]
        public PromoterDeleteInfo PromoterDeleteResult { get; set; }
    }
}
