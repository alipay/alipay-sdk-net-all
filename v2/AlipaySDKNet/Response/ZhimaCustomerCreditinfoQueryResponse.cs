using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerCreditinfoQueryResponse.
    /// </summary>
    public class ZhimaCustomerCreditinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 当auth=true时，才会返回credit_level_code
        /// </summary>
        [XmlElement("auth")]
        public bool Auth { get; set; }

        /// <summary>
        /// 当can_auth=true时，auth_award才会有值，如果用户之前因为授权获得过奖励，则auth_award为false
        /// </summary>
        [XmlElement("auth_award")]
        public bool AuthAward { get; set; }

        /// <summary>
        /// auth_award=false，该值不存在；auth_award=true，该值为1~100（进度值）
        /// </summary>
        [XmlElement("award")]
        public string Award { get; set; }

        /// <summary>
        /// 当auth=false时，can_auth才会有值
        /// </summary>
        [XmlElement("can_auth")]
        public bool CanAuth { get; set; }

        /// <summary>
        /// 根据用户芝麻分所在区间返回命中的信用等级
        /// </summary>
        [XmlElement("credit_level_code")]
        public string CreditLevelCode { get; set; }

        /// <summary>
        /// 高德侧可保存该字段进行核对，当auth=true时，才会返回
        /// </summary>
        [XmlElement("sign_id")]
        public string SignId { get; set; }
    }
}
