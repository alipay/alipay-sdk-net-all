using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotvspUserstateQueryResponse.
    /// </summary>
    public class AlipayOpenIotvspUserstateQueryResponse : AopResponse
    {
        /// <summary>
        /// 0-不下发 1-下发
        /// </summary>
        [XmlElement("client_group_state")]
        public long ClientGroupState { get; set; }

        /// <summary>
        /// 返回用户在团餐、门禁等人脸库场景的状态，1在库2不在库3在开放库4在封闭库
        /// </summary>
        [XmlElement("group_state")]
        public string GroupState { get; set; }

        /// <summary>
        /// 返回用户是否在库（1：在库，2：不在库）
        /// </summary>
        [XmlElement("state")]
        public string State { get; set; }
    }
}
