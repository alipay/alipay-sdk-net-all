using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpAcceptanceLabelUseModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpAcceptanceLabelUseModel : AopObject
    {
        /// <summary>
        /// 实力标场景表现数据
        /// </summary>
        [XmlArray("feedback_data")]
        [XmlArrayItem("label_feedback_detail_model")]
        public List<LabelFeedbackDetailModel> FeedbackData { get; set; }

        /// <summary>
        /// 场景码，实力标查询企信分配给商户的场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
