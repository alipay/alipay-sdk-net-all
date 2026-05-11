using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalExaminationCspudetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalExaminationCspudetailQueryModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("spu_id_list")]
        [XmlArrayItem("string")]
        public List<string> SpuIdList { get; set; }
    }
}
