using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserStepcounterNoauthrequiredBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserStepcounterNoauthrequiredBatchqueryModel : AopObject
    {
        /// <summary>
        /// 步数数据查询的结束日期。此日期不能小于步数查询的开始日期
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 请求方唯一标识。每一个外部商户都会分配一个业务方标识，请联系接口负责人获取
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 步数数据查询的开始日期
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 用户的计步时区。若不为空，返回指定时区的运动步数，若此参数为空，则返回所有时区的步数信息。
        /// </summary>
        [XmlElement("time_zone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
