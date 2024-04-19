using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusSchedualconfigSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataAiserviceCloudbusSchedualconfigSetModel : AopObject
    {
        /// <summary>
        /// 接口版本号
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 配制名称
        /// </summary>
        [XmlElement("config_name")]
        public string ConfigName { get; set; }

        /// <summary>
        /// 公交公司id
        /// </summary>
        [XmlElement("corp_id")]
        public string CorpId { get; set; }

        /// <summary>
        /// 日期列表
        /// </summary>
        [XmlArray("date")]
        [XmlArrayItem("string")]
        public List<string> Date { get; set; }
    }
}
