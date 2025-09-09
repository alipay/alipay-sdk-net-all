using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalAnttechAppcoreUserbizinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalAnttechAppcoreUserbizinfoQueryModel : AopObject
    {
        /// <summary>
        /// 公司统一社会信用证代码，如所属供热公司统一社会信用证代码
        /// </summary>
        [XmlElement("company_uscc")]
        public string CompanyUscc { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 查询类型，按手机号还是卡来查询
        /// </summary>
        [XmlElement("query_type")]
        public string QueryType { get; set; }

        /// <summary>
        /// 供热住户的id,来自供热公司的的定义，是由热力公司返回的自定义id
        /// </summary>
        [XmlElement("resident_id")]
        public string ResidentId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
