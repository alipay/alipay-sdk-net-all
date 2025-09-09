using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataAntsycmCrowserviceQueryResponse.
    /// </summary>
    public class AlipayDataAntsycmCrowserviceQueryResponse : AopResponse
    {
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
        /// 1、如果 service_type=is_exist_in_crowd，则返回 1表示存在、0表示不存在 2、如果 service_type=tag_score，则返回具体打分值，如0、99.24等
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
