using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppCommunityUserpromoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppCommunityUserpromoSyncModel : AopObject
    {
        /// <summary>
        /// 业务数据
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 场景来源(创建时必填，其他更新时可以不填)
        /// </summary>
        [XmlElement("scene_src")]
        public string SceneSrc { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 发放对象
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 营销活动类型（券/红包/xxx）
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 支付宝用户user_id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
