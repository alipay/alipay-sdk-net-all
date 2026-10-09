using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IotVspOrgUserDeleteNotifyUserInfoRequest Data Structure.
    /// </summary>
    [Serializable]
    public class IotVspOrgUserDeleteNotifyUserInfoRequest : AopObject
    {
        /// <summary>
        /// 返回状态描述
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 返回出库状态（1：成功，2：失败）
        /// </summary>
        [XmlElement("state")]
        public string State { get; set; }

        /// <summary>
        /// 机构用户ID
        /// </summary>
        [XmlElement("vid")]
        public string Vid { get; set; }
    }
}
