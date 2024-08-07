using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalLargermodelSessionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalLargermodelSessionQueryModel : AopObject
    {
        /// <summary>
        /// 区分请求来源
        /// </summary>
        [XmlElement("app_type")]
        public string AppType { get; set; }

        /// <summary>
        /// 行业侧生成，首次为空
        /// </summary>
        [XmlElement("chat_id")]
        public string ChatId { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 用户openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用于区分同一个app下的机构
        /// </summary>
        [XmlElement("org_id")]
        public string OrgId { get; set; }

        /// <summary>
        /// 用户的userId。
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 当out_user_id为2088uid时，需将这个值设置为：ALIPAY_UID；当out_user_id为其他值时，可将这个值设置为：OTHER_UID；若是open_id时，设置为ALIPAY_OPENID
        /// </summary>
        [XmlElement("outer_user_type")]
        public string OuterUserType { get; set; }

        /// <summary>
        /// 若为空则走意图识别 否则跳过意图识别接口，直接路由 医疗科普——MEDICALSCI 用药指南—— DRUGGUIDE 智能导诊—— DEPARTGUIDE
        /// </summary>
        [XmlElement("pre_intention")]
        public string PreIntention { get; set; }

        /// <summary>
        /// 用户问题描述，初始化时无query
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// 用于区分query类型
        /// </summary>
        [XmlElement("query_type")]
        public string QueryType { get; set; }

        /// <summary>
        /// 区分当前对话场景意图 前缀不同，不做强枚举校验
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 若为空，则为本轮第一次对话 初始化
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
