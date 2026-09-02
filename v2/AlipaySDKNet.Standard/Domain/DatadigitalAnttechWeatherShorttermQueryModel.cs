using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalAnttechWeatherShorttermQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalAnttechWeatherShorttermQueryModel : AopObject
    {
        /// <summary>
        /// 蚂蚁数科气象服务产品码，找蚂蚁数科运营同学获取
        /// </summary>
        [XmlElement("agreement_code")]
        public string AgreementCode { get; set; }

        /// <summary>
        /// 纬度，表示地理位置的纬度坐标，单位为度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度，表示地理位置的经度坐标，单位为度。
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 请求 ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
