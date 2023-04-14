using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialBaseChatGmemberConfirmResponse.
    /// </summary>
    public class AlipaySocialBaseChatGmemberConfirmResponse : AopResponse
    {
        /// <summary>
        /// 所属的群id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 是否在群中
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
