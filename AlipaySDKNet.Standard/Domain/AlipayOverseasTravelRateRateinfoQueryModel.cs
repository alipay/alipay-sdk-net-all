using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTravelRateRateinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTravelRateRateinfoQueryModel : AopObject
    {
        /// <summary>
        /// 用户当前所在国家的国家码，ISO-3166标准三位数字国家码。 1.currency、country_code、longitude&latitude三者不能同时为空； 2.同时存在时优先级：currency>country_code>longitude&latitude；
        /// </summary>
        [XmlElement("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// 货币代码，ISO标准alpha-3币种代码 1.currency、country_code、longitude&latitude三者不能同时为空 2.同时存在时优先级：currency>country_code>longitude&latitude；
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 币种金额：不传的时候默认100，单位元
        /// </summary>
        [XmlElement("currency_amount")]
        public string CurrencyAmount { get; set; }

        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [XmlElement("extend_param")]
        public string ExtendParam { get; set; }

        /// <summary>
        /// 纬度；currency、country_code、longitude & latitude三者不能同时为空，同时存在时优先级：currency>country_code>longitude&latitude；
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度； 1.currency、country_code、longitude&latitude三者不能同时为空； 2.同时存在时优先级：currency>country_code>longitude&latitude；
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
