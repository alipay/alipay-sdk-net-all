using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalLargermodelFeedbackSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalLargermodelFeedbackSendModel : AopObject
    {
        /// <summary>
        /// 卡片信息
        /// </summary>
        [XmlElement("card_data")]
        public string CardData { get; set; }

        /// <summary>
        /// 云陪诊卡片事件名称
        /// </summary>
        [XmlElement("card_event")]
        public string CardEvent { get; set; }

        /// <summary>
        /// 卡片服务
        /// </summary>
        [XmlElement("card_service")]
        public string CardService { get; set; }

        /// <summary>
        /// 对话id
        /// </summary>
        [XmlElement("chat_id")]
        public string ChatId { get; set; }

        /// <summary>
        /// 是
        /// </summary>
        [XmlElement("close_cloud_escort_flag")]
        public bool CloseCloudEscortFlag { get; set; }

        /// <summary>
        /// 反馈行动点： ● 右下角：lowerRightCorner ● 长按：tapAndHold ● 选取文字：selectText ● 云陪诊首页服务：ypzHomePage ● 云陪诊消息进对话：ypzMessageForwardSession ● 云陪诊浮层：ypzSuperposeLayer
        /// </summary>
        [XmlElement("feedback_ap")]
        public string FeedbackAp { get; set; }

        /// <summary>
        /// 反馈渠道： ● 安诊儿app：azeApp ● 安诊儿小程序：azeMiniProgram ● 健康管家app：healthManagerApp ● 健康管家小程序：healthManagerMiniProgram
        /// </summary>
        [XmlElement("feedback_channel")]
        public string FeedbackChannel { get; set; }

        /// <summary>
        /// 反馈类别： ● 常规问答：generalQA ● 深度思考：deepThinking ● 深入问答追问：depthQAFollowUp ● 多模态反馈（报告解读、药盒识别）：multimodal ● 云陪诊：cloudAccompaniedAiagnosis ● 深度思考+多模态反馈：deepThinkingAndMultimodal 云陪诊住院反馈：ypzHospitalized
        /// </summary>
        [XmlElement("feedback_class")]
        public string FeedbackClass { get; set; }

        /// <summary>
        /// 用户手动输入的内容
        /// </summary>
        [XmlElement("feedback_input")]
        public string FeedbackInput { get; set; }

        /// <summary>
        /// 用户选择文字
        /// </summary>
        [XmlElement("feedback_select_content")]
        public string FeedbackSelectContent { get; set; }

        /// <summary>
        /// 反馈标签
        /// </summary>
        [XmlElement("feedback_tag")]
        public string FeedbackTag { get; set; }

        /// <summary>
        /// 反馈类型： ● 点赞：praise ● 点踩：stepOn ● 取消：cancel
        /// </summary>
        [XmlElement("feedback_type")]
        public string FeedbackType { get; set; }

        /// <summary>
        /// 医院id
        /// </summary>
        [XmlElement("hospital_id")]
        public string HospitalId { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        [XmlElement("org_id")]
        public string OrgId { get; set; }

        /// <summary>
        /// 支付宝用户id，为对外开放新增字段，对外开放时必填。（可以为外部用户ID，同一次陪诊需要传同一个ID）
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 当out_user_id为2088uid时，需将这个值设置为：ALIPAY_UID；当out_user_id为其他值时，可将这个值设置为：OTHER_UID；
        /// </summary>
        [XmlElement("outer_user_type")]
        public string OuterUserType { get; set; }

        /// <summary>
        /// 会话id
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 云陪诊id
        /// </summary>
        [XmlElement("ypz_id")]
        public string YpzId { get; set; }
    }
}
