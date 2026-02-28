using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpAssistantMembershippackageQueryResponse.
    /// </summary>
    public class ZhimaCreditEpAssistantMembershippackageQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("licenses")]
        [XmlArrayItem("string")]
        public List<string> Licenses { get; set; }

        /// <summary>
        /// 剩余可解锁数量
        /// </summary>
        [XmlElement("unlock_right_num")]
        public long UnlockRightNum { get; set; }
    }
}
