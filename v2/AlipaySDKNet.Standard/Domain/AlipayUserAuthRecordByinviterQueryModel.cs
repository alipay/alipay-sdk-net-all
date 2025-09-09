using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAuthRecordByinviterQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAuthRecordByinviterQueryModel : AopObject
    {
        /// <summary>
        /// true：过滤过期数据；
        /// </summary>
        [XmlElement("check_expire")]
        public bool CheckExpire { get; set; }

        /// <summary>
        /// 被邀请人id
        /// </summary>
        [XmlElement("invited_id")]
        public string InvitedId { get; set; }

        /// <summary>
        /// 被邀请人id
        /// </summary>
        [XmlElement("invited_openid")]
        public string InvitedOpenid { get; set; }

        /// <summary>
        /// 被邀请人状态
        /// </summary>
        [XmlArray("invited_status")]
        [XmlArrayItem("string")]
        public List<string> InvitedStatus { get; set; }

        /// <summary>
        /// 邀请人id
        /// </summary>
        [XmlElement("inviter_id")]
        public string InviterId { get; set; }

        /// <summary>
        /// 邀请人id
        /// </summary>
        [XmlElement("inviter_openid")]
        public string InviterOpenid { get; set; }

        /// <summary>
        /// 邀请人状态
        /// </summary>
        [XmlArray("inviter_status")]
        [XmlArrayItem("string")]
        public List<string> InviterStatus { get; set; }

        /// <summary>
        /// 分页索引
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小，单位条
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 集集鸡蛋业务场景，字段取值是技术约定的字符串；必须；不可枚举类型；
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }
    }
}
