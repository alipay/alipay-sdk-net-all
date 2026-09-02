using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FollowUpCreateTaskBizIdRequest Data Structure.
    /// </summary>
    [Serializable]
    public class FollowUpCreateTaskBizIdRequest : AopObject
    {
        /// <summary>
        /// 蚂蚁健康OpenID
        /// </summary>
        [XmlElement("aq_open_id")]
        public string AqOpenId { get; set; }

        /// <summary>
        /// 外部业务流水号
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }
    }
}
