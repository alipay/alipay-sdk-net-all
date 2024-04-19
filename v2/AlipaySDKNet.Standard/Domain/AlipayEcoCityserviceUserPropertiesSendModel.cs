using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoCityserviceUserPropertiesSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCityserviceUserPropertiesSendModel : AopObject
    {
        /// <summary>
        /// 城市
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 数据同步类型
        /// </summary>
        [XmlElement("cud_type")]
        public string CudType { get; set; }

        /// <summary>
        /// 行业类型
        /// </summary>
        [XmlElement("industry_type")]
        public string IndustryType { get; set; }

        /// <summary>
        /// 用户属性类型
        /// </summary>
        [XmlElement("prop_type")]
        public string PropType { get; set; }

        /// <summary>
        /// 用户属性值
        /// </summary>
        [XmlElement("prop_value")]
        public string PropValue { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
