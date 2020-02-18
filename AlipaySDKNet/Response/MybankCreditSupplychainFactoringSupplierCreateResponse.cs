using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSupplychainFactoringSupplierCreateResponse.
    /// </summary>
    public class MybankCreditSupplychainFactoringSupplierCreateResponse : AopResponse
    {
        /// <summary>
        /// supplierNo : 供应商编号
        /// </summary>
        [XmlElement("supplier_no")]
        public string SupplierNo { get; set; }
    }
}
