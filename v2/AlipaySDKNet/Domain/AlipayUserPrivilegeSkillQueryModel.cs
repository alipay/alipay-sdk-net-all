using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserPrivilegeSkillQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserPrivilegeSkillQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝用户的地理位置信息
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 用户经纬度信息之精度信息
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 用户lbs信息之维度信息
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 未来用于兼容获取特权摘要信息与详情信息
        /// </summary>
        [XmlElement("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
