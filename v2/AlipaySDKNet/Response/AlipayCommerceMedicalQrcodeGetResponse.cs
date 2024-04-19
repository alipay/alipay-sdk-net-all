using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalQrcodeGetResponse.
    /// </summary>
    public class AlipayCommerceMedicalQrcodeGetResponse : AopResponse
    {
        /// <summary>
        /// 就诊人默认参保地映射后的地市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 就诊人默认参保地映射后的城市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 就诊人默认参保地编码
        /// </summary>
        [XmlElement("ins_city_code")]
        public string InsCityCode { get; set; }

        /// <summary>
        /// 就诊人默认参保地名称
        /// </summary>
        [XmlElement("ins_city_name")]
        public string InsCityName { get; set; }

        /// <summary>
        /// 就诊人医保码值
        /// </summary>
        [XmlElement("qrcode")]
        public string Qrcode { get; set; }

        /// <summary>
        /// 就诊人医保码值的关系类型
        /// </summary>
        [XmlElement("relation_type")]
        public string RelationType { get; set; }
    }
}
