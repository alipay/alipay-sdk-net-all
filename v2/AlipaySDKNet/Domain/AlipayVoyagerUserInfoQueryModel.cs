using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayVoyagerUserInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayVoyagerUserInfoQueryModel : AopObject
    {
        /// <summary>
        /// 通过Voyager提供的前端SDK获取的用户授权CODE
        /// </summary>
        [XmlElement("auth_code")]
        public string AuthCode { get; set; }
    }
}
