using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SupplierDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SupplierDTO : AopObject
    {
        /// <summary>
        /// 供应商code
        /// </summary>
        [XmlElement("supplier_code")]
        public string SupplierCode { get; set; }

        /// <summary>
        /// 供应商id
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }

        /// <summary>
        /// 供应商名称
        /// </summary>
        [XmlElement("supplier_name")]
        public string SupplierName { get; set; }
    }
}
