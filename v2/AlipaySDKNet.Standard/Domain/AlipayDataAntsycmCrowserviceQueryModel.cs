using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataAntsycmCrowserviceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataAntsycmCrowserviceQueryModel : AopObject
    {
        /// <summary>
        /// 商户授权码
        /// </summary>
        [XmlElement("business_code")]
        public string BusinessCode { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 1、如果：service_type=is_exist_in_crowd 则入参是：人群ID 2、如果：service_type=tag_score 则入参是：对应打分：标识ID
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// is_exist_in_crowd:查询用户是否存在于人群中  tag_score:查询当前用户的评分
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_sign")]
        public string UserSign { get; set; }

        /// <summary>
        /// 用户ID类型
        /// </summary>
        [XmlElement("user_sign_type")]
        public string UserSignType { get; set; }
    }
}
