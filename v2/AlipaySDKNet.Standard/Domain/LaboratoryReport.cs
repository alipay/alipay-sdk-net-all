using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LaboratoryReport Data Structure.
    /// </summary>
    [Serializable]
    public class LaboratoryReport : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("result_info_list")]
        [XmlArrayItem("laboratory_result_info")]
        public List<LaboratoryResultInfo> ResultInfoList { get; set; }
    }
}
