using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceHdfaitransferMedicationguidanceGenerateResponse.
    /// </summary>
    public class AlipayCommerceHdfaitransferMedicationguidanceGenerateResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("medication_guidance_item")]
        public List<MedicationGuidanceItem> Data { get; set; }
    }
}
