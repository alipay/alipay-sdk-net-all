using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncInvoiceAfterdistributeModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncInvoiceAfterdistributeModifyModel : AopObject
    {
        /// <summary>
        /// 修改参数
        /// </summary>
        [XmlElement("input_invoice_modify_after_distribute_dto")]
        public InputInvoiceModifyAfterDistributeDTO InputInvoiceModifyAfterDistributeDto { get; set; }
    }
}
