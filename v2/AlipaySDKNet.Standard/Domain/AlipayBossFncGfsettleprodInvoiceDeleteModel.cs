using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfsettleprodInvoiceDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfsettleprodInvoiceDeleteModel : AopObject
    {
        /// <summary>
        /// 发票操作对象
        /// </summary>
        [XmlElement("invoice_operate_param")]
        public InvoiceOperateParam InvoiceOperateParam { get; set; }
    }
}
