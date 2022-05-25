using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarVehicleModelQueryResponse.
    /// </summary>
    public class AlipayEcoMycarVehicleModelQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝车型列表
        /// </summary>
        [XmlArray("veh_model_list")]
        [XmlArrayItem("veh_model_dto")]
        public List<VehModelDto> VehModelList { get; set; }
    }
}
