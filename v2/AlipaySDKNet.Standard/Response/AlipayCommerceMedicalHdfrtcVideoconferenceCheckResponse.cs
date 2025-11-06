using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHdfrtcVideoconferenceCheckResponse.
    /// </summary>
    public class AlipayCommerceMedicalHdfrtcVideoconferenceCheckResponse : AopResponse
    {
        /// <summary>
        /// 是否允许接入会议（0：不允许 1：允许）
        /// </summary>
        [XmlElement("can_enter")]
        public long CanEnter { get; set; }

        /// <summary>
        /// 对方是否进入会议室提醒
        /// </summary>
        [XmlElement("party_entered_tips")]
        public string PartyEnteredTips { get; set; }

        /// <summary>
        /// 弹窗文案
        /// </summary>
        [XmlArray("remind_text_list")]
        [XmlArrayItem("remind_text_info")]
        public List<RemindTextInfo> RemindTextList { get; set; }

        /// <summary>
        /// 弹窗标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
