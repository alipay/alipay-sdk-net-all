using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppEdeductForecastQueryResponse.
    /// </summary>
    public class AlipayEbppEdeductForecastQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否符合预期，true则说明符合预测，false则说明不符合预测，需要进行拦截。
        /// </summary>
        [XmlElement("forecast_expect")]
        public bool ForecastExpect { get; set; }
    }
}
