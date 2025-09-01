using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalInvoiceCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalInvoiceCreateModel : AopObject
    {
        /// <summary>
        /// 总代发货单创建请求体
        /// </summary>
        [XmlElement("fxiaoke_create_invoice_request")]
        public FxiaokeCreateInvoiceRequest FxiaokeCreateInvoiceRequest { get; set; }
    }
}
