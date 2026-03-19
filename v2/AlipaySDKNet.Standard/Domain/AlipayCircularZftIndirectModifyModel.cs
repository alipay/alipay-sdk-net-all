using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCircularZftIndirectModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCircularZftIndirectModifyModel : AopObject
    {
        /// <summary>
        /// 默认结算账号
        /// </summary>
        [XmlElement("default_settle_rule")]
        public ZftDefaultSettleRule DefaultSettleRule { get; set; }

        /// <summary>
        /// 进件申请单中的二级商户openid
        /// </summary>
        [XmlElement("relation_openid")]
        public string RelationOpenid { get; set; }

        /// <summary>
        /// 进件账户id
        /// </summary>
        [XmlElement("relation_uid")]
        public string RelationUid { get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
