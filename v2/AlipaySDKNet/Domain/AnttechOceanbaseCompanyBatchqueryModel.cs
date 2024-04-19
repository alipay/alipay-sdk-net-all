using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseCompanyBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseCompanyBatchqueryModel : AopObject
    {
        /// <summary>
        /// 企业id列表
        /// </summary>
        [XmlArray("entity_id_list")]
        [XmlArrayItem("string")]
        public List<string> EntityIdList { get; set; }
    }
}
