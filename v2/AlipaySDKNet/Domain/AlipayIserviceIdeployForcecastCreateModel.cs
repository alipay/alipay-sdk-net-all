using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIdeployForcecastCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIdeployForcecastCreateModel : AopObject
    {
        /// <summary>
        /// 预测数据
        /// </summary>
        [XmlElement("forecast_data")]
        public IdeployForecastData ForecastData { get; set; }

        /// <summary>
        /// 租户CODE
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
