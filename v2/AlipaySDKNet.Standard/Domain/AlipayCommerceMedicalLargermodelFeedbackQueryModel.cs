using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalLargermodelFeedbackQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalLargermodelFeedbackQueryModel : AopObject
    {
        /// <summary>
        /// 反馈渠道： ● 安诊儿app：azeApp ● 安诊儿小程序：azeMiniProgram ● 健康管家app：healthManagerApp ● 健康管家小程序：healthManagerMiniProgram
        /// </summary>
        [XmlElement("feedback_channel")]
        public string FeedbackChannel { get; set; }

        /// <summary>
        /// 反馈场景: 常规问答：generalQA 深度思考：deepThinking 深入问答追问：depthQAFollowUp 多模态反馈（报告解读、药盒识别）：multimodal 云陪诊：cloudAccompaniedAiagnosis 深度思考+多模态反馈：deepThinkingAndMultimodal 云陪诊住院反馈:ypzHospitalized 云陪诊nps低分：ypzNpsLow 云陪诊nps中分：ypzNpsMid 云陪诊nps高分：ypzNpsHigh nps低分：npsLow nps中分：npsMid nps高分：npsHigh
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 当【反馈场景】为【云陪诊】时必填 ● 有：yes ● 无：no
        /// </summary>
        [XmlElement("service_status")]
        public string ServiceStatus { get; set; }
    }
}
