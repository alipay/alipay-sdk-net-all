using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalExaminationCspudetailQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalExaminationCspudetailQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("spu_info_list")]
        [XmlArrayItem("examination_spu_info")]
        public List<ExaminationSpuInfo> SpuInfoList { get; set; }
    }
}
