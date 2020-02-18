using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrVehicledashboardQueryResponse.
    /// </summary>
    public class AlipayIserviceCognitiveOcrVehicledashboardQueryResponse : AopResponse
    {
        /// <summary>
        /// 服务ip
        /// </summary>
        [XmlElement("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// 识别结果
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("vehicle_dashboard_result")]
        public List<VehicleDashboardResult> Result { get; set; }

        /// <summary>
        /// 0为识别成功，1为识别失败
        /// </summary>
        [XmlElement("ret")]
        public long Ret { get; set; }

        /// <summary>
        /// 识别服务的RT,单位为毫秒ms
        /// </summary>
        [XmlElement("rt")]
        public long Rt { get; set; }

        /// <summary>
        /// 识别服务的session id
        /// </summary>
        [XmlElement("sid")]
        public string Sid { get; set; }
    }
}
