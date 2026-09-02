using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalServicepackageGrantbyphonenoCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalServicepackageGrantbyphonenoCancelModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("order_no_list")]
        [XmlArrayItem("string")]
        public List<string> OrderNoList { get; set; }
    }
}
