using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoMessageCallCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoMessageCallCreateModel : AopObject
    {
        /// <summary>
        /// 触达策略
        /// </summary>
        [XmlElement("contact_strategy")]
        public ContactStrategy ContactStrategy { get; set; }

        /// <summary>
        /// 传递触达策略
        /// </summary>
        [XmlElement("contact_type")]
        public string ContactType { get; set; }

        /// <summary>
        /// 用户基本信息，触达时用于和对方确认身份及称呼
        /// </summary>
        [XmlArray("user_infos")]
        [XmlArrayItem("call_user_info")]
        public List<CallUserInfo> UserInfos { get; set; }
    }
}
