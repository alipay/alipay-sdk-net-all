using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoTravelWeatherQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoTravelWeatherQueryResponse : AopResponse
    {
        /// <summary>
        /// 天气结构
        /// </summary>
        [XmlElement("ai_weather_vo")]
        public AiWeatherVo AiWeatherVo { get; set; }

        /// <summary>
        /// 天气详情跳转链接
        /// </summary>
        [XmlElement("result_url")]
        public string ResultUrl { get; set; }
    }
}
