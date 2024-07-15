using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QueryInvoiceInfoByOuOpenApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class QueryInvoiceInfoByOuOpenApiDTO : AopObject
    {
        /// <summary>
        /// ouCode列表
        /// </summary>
        [XmlArray("ou_code_list")]
        [XmlArrayItem("string")]
        public List<string> OuCodeList { get; set; }
    }
}
