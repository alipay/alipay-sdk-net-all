using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasBcmPageparamQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasBcmPageparamQueryModel : AopObject
    {
        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// groovy脚本code
        /// </summary>
        [XmlElement("groovy_code")]
        public string GroovyCode { get; set; }

        /// <summary>
        /// 页面阶段
        /// </summary>
        [XmlElement("page_stage")]
        public string PageStage { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [XmlElement("prov_name")]
        public string ProvName { get; set; }
    }
}
