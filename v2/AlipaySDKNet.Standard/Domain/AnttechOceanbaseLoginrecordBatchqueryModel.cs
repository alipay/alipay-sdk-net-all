using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseLoginrecordBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseLoginrecordBatchqueryModel : AopObject
    {
        /// <summary>
        /// 通行证id列表
        /// </summary>
        [XmlArray("passport_ids")]
        [XmlArrayItem("string")]
        public List<string> PassportIds { get; set; }
    }
}
