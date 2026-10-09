using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportCarbonDataQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportCarbonDataQueryModel : AopObject
    {
        /// <summary>
        /// 业务结束时间  yyyy-MM-dd HH:mm:ss 格式
        /// </summary>
        [XmlElement("biz_date_end")]
        public string BizDateEnd { get; set; }

        /// <summary>
        /// 业务开始时间  yyyy-MM-dd HH:mm:sss 格式
        /// </summary>
        [XmlElement("biz_date_start")]
        public string BizDateStart { get; set; }

        /// <summary>
        /// 业务场景，目前支持BUS、METRO
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 城市code
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID（对外openId版本）
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
