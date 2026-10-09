using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerversionCitygrayQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerversionCitygrayQueryResponse : AopResponse
    {
        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 城市编码列表
        /// </summary>
        [XmlArray("city_codes")]
        [XmlArrayItem("string")]
        public List<string> CityCodes { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 城市信息列表
        /// </summary>
        [XmlArray("gray_citys")]
        [XmlArrayItem("mini_app_gray_city_dto")]
        public List<MiniAppGrayCityDto> GrayCitys { get; set; }

        /// <summary>
        /// 规则编码
        /// </summary>
        [XmlElement("rule_code")]
        public string RuleCode { get; set; }
    }
}
