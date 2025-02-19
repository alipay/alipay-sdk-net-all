using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHealthGaugeQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalHealthGaugeQueryResponse : AopResponse
    {
        /// <summary>
        /// 自测量表列表
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("gauge_type_list_d_t_o")]
        public List<GaugeTypeListDTO> Data { get; set; }
    }
}
