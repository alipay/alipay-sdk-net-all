using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneFinresearchSessionDetailModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneFinresearchSessionDetailModifyModel : AopObject
    {
        /// <summary>
        /// 本次会话的主体ID
        /// </summary>
        [XmlElement("identity_id")]
        public string IdentityId { get; set; }

        /// <summary>
        /// 修改历史记录中的标题内容
        /// </summary>
        [XmlElement("new_title")]
        public string NewTitle { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 会话ID
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
