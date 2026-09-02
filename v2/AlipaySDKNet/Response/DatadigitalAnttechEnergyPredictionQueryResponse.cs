using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalAnttechEnergyPredictionQueryResponse.
    /// </summary>
    public class DatadigitalAnttechEnergyPredictionQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("prediction_result_point_d_t_o")]
        public List<PredictionResultPointDTO> DataList { get; set; }
    }
}
