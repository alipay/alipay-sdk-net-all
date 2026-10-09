using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossBaseProcessInstanceUrgeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossBaseProcessInstanceUrgeModel : AopObject
    {
        /// <summary>
        /// 模板
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 这个是发消息使用，直接传给jar包的，请以JSON的格式传送字符串，内部使用的是map，但是此平台不支持map，所以定义成String，但是请以JSON的格式传送
        /// </summary>
        [XmlElement("msg_template")]
        public string MsgTemplate { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        [XmlArray("msg_type_list")]
        [XmlArrayItem("string")]
        public List<string> MsgTypeList { get; set; }

        /// <summary>
        /// 流程实例Id
        /// </summary>
        [XmlElement("puid")]
        public string Puid { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
