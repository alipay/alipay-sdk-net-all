using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalPrescriptionListQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalPrescriptionListQueryResponse : AopResponse
    {
        /// <summary>
        /// 处方信息合集
        /// </summary>
        [XmlArray("prsc_list")]
        [XmlArrayItem("prsc_v_o")]
        public List<PrscVO> PrscList { get; set; }
    }
}
