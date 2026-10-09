using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChatRecordInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ChatRecordInfo : AopObject
    {
        /// <summary>
        /// 交流记录中的信息内容
        /// </summary>
        [XmlElement("msg_content")]
        public string MsgContent { get; set; }

        /// <summary>
        /// 交流记录中发言人的昵称
        /// </summary>
        [XmlElement("nick_name")]
        public string NickName { get; set; }
    }
}
