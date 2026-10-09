using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupWelcomemsgModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupWelcomemsgModifyModel : AopObject
    {
        /// <summary>
        /// 群组id列表
        /// </summary>
        [XmlArray("group_ids")]
        [XmlArrayItem("string")]
        public List<string> GroupIds { get; set; }

        /// <summary>
        /// 入群欢迎语
        /// </summary>
        [XmlElement("welcome_msg")]
        public GroupWelcomeMsgVO WelcomeMsg { get; set; }
    }
}
