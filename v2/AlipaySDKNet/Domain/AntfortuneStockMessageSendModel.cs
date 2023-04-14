using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneStockMessageSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneStockMessageSendModel : AopObject
    {
        /// <summary>
        /// 签约协议号（uid在某个机构处的唯一标识）
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 消息大类：股票-STOCK，信托-TRUST
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 消息id、用来控制消息幂等
        /// </summary>
        [XmlElement("msg_id")]
        public string MsgId { get; set; }

        /// <summary>
        /// 参数列表，用来替换消息模板中的内容
        /// </summary>
        [XmlArray("param")]
        [XmlArrayItem("kv")]
        public List<Kv> Param { get; set; }

        /// <summary>
        /// 子类别：新股中签、etc
        /// </summary>
        [XmlElement("sub_category")]
        public string SubCategory { get; set; }

        /// <summary>
        /// 消息类型、关联发送的消息模板
        /// </summary>
        [XmlElement("template")]
        public string Template { get; set; }
    }
}
