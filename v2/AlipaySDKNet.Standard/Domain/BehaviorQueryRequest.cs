using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BehaviorQueryRequest Data Structure.
    /// </summary>
    [Serializable]
    public class BehaviorQueryRequest : AopObject
    {
        /// <summary>
        /// 查询访问用户 30 天内访问频次（次）和时长（天）（scene_code=vis_features）、查询会员用户 30 天内支付频次（次）和支付客单（元）（scene_code=mem_features）、以及查询支付用户 30 天内支付频次（次）、支付客单（元）和支付距今天数（天）（scene_code=pay_user_features）时必填。
        /// </summary>
        [XmlElement("feature")]
        public string Feature { get; set; }

        /// <summary>
        /// 关系对象主体类型id，即资产关系是建立在什么对象id上的，如小程序appid、生活号id、直播间id、卡模板id等。
        /// </summary>
        [XmlElement("object_id")]
        public string ObjectId { get; set; }

        /// <summary>
        /// 关系对象主体类型，即资产关系是建立在什么对象上的。查询用户来源分布（scene_code=all_users_distribution）、查询访问用户 30 天内访问频次（次）和时长（天）（scene_code=vis_features）、查询支付用户 30 天内支付频次（次）、支付客单（元）和支付距今天数（天）（scene_code=pay_user_features）时必填。
        /// </summary>
        [XmlElement("object_type")]
        public string ObjectType { get; set; }

        /// <summary>
        /// 用户资产关系类型，查询用户来源分布（scene_code=all_users_distribution）时必填。
        /// </summary>
        [XmlElement("relation_type")]
        public string RelationType { get; set; }

        /// <summary>
        /// 数据日期，格式yyyyMMdd。
        /// </summary>
        [XmlElement("report_date")]
        public string ReportDate { get; set; }
    }
}
