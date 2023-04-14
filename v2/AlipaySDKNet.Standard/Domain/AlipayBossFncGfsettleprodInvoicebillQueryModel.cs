using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfsettleprodInvoicebillQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfsettleprodInvoicebillQueryModel : AopObject
    {
        /// <summary>
        /// 结算单查询
        /// </summary>
        [XmlElement("payment_apply_query_order")]
        public PaymentApplyQueryOrder PaymentApplyQueryOrder { get; set; }
    }
}
