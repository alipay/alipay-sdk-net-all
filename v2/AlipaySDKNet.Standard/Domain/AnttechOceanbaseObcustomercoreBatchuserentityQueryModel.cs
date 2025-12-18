using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObcustomercoreBatchuserentityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObcustomercoreBatchuserentityQueryModel : AopObject
    {
        /// <summary>
        /// 用户通行证ID集合，通过入参传入
        /// </summary>
        [XmlArray("passport_ids")]
        [XmlArrayItem("string")]
        public List<string> PassportIds { get; set; }
    }
}
