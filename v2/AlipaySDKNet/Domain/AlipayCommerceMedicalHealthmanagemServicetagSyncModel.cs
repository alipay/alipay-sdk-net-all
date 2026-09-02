using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHealthmanagemServicetagSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHealthmanagemServicetagSyncModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("service_tag_list")]
        [XmlArrayItem("service_tag_param")]
        public List<ServiceTagParam> ServiceTagList { get; set; }
    }
}
