using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataMdaMiniappstaticQueryResponse.
    /// </summary>
    public class AlipayDataMdaMiniappstaticQueryResponse : AopResponse
    {
        /// <summary>
        /// 住宿
        /// </summary>
        [XmlElement("accommodation")]
        public string Accommodation { get; set; }

        /// <summary>
        /// 美食
        /// </summary>
        [XmlElement("fine_food")]
        public string FineFood { get; set; }

        /// <summary>
        /// 了解亚运
        /// </summary>
        [XmlElement("focus_ag")]
        public string FocusAg { get; set; }

        /// <summary>
        /// 多语言版
        /// </summary>
        [XmlElement("language_version")]
        public string LanguageVersion { get; set; }

        /// <summary>
        /// 一码出行
        /// </summary>
        [XmlElement("one_yard_trip")]
        public string OneYardTrip { get; set; }

        /// <summary>
        /// 景点
        /// </summary>
        [XmlElement("scenic_spot")]
        public string ScenicSpot { get; set; }

        /// <summary>
        /// 服务场景
        /// </summary>
        [XmlElement("service_scenario")]
        public long ServiceScenario { get; set; }

        /// <summary>
        /// 服务场景词云图
        /// </summary>
        [XmlElement("service_scenario_map")]
        public string ServiceScenarioMap { get; set; }
    }
}
