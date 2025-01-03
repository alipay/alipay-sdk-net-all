using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MultiSignerAndTabVosDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MultiSignerAndTabVosDTO : AopObject
    {
        /// <summary>
        /// ture表示自动签署，false表示手动签署。不传默认false
        /// </summary>
        [XmlElement("auto")]
        public bool Auto { get; set; }

        /// <summary>
        /// 电子邮件主题 最大99个字
        /// </summary>
        [XmlElement("email_body")]
        public string EmailBody { get; set; }

        /// <summary>
        /// 电子邮件消息 最大1000个字
        /// </summary>
        [XmlElement("email_subject")]
        public string EmailSubject { get; set; }

        /// <summary>
        /// 是否需要Docusign邮件通知，默认true
        /// </summary>
        [XmlElement("need_emai_notice")]
        public bool NeedEmaiNotice { get; set; }

        /// <summary>
        /// 签约顺序 1~10 不同的人请保持不一致
        /// </summary>
        [XmlElement("order")]
        public long Order { get; set; }

        /// <summary>
        /// 标记唯一的签字人id （必传）
        /// </summary>
        [XmlElement("recipient_id")]
        public string RecipientId { get; set; }

        /// <summary>
        /// 区分内部外部人员，默认内部
        /// </summary>
        [XmlElement("side")]
        public string Side { get; set; }

        /// <summary>
        /// 签署人邮箱(外部)
        /// </summary>
        [XmlElement("signer_email")]
        public string SignerEmail { get; set; }

        /// <summary>
        /// 签署人姓名
        /// </summary>
        [XmlElement("signer_name")]
        public string SignerName { get; set; }

        /// <summary>
        /// 签署人工号（内部）
        /// </summary>
        [XmlElement("signer_num")]
        public string SignerNum { get; set; }

        /// <summary>
        /// 电子邮件语言：无特殊要求请使用en
        /// </summary>
        [XmlElement("supported_language")]
        public string SupportedLanguage { get; set; }

        /// <summary>
        /// 签署组件信息
        /// </summary>
        [XmlArray("tabs")]
        [XmlArrayItem("seal_tabs_v_o")]
        public List<SealTabsVO> Tabs { get; set; }
    }
}
