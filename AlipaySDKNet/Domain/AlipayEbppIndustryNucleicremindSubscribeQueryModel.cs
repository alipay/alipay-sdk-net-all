using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryNucleicremindSubscribeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryNucleicremindSubscribeQueryModel : AopObject
    {
        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 支付宝会员id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝会员id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
