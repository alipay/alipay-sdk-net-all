using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskGuardrailsAnswerDetectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskGuardrailsAnswerDetectModel : AopObject
    {
        /// <summary>
        /// 当前回答内容，最大长度10000个字符。回答时必传
        /// </summary>
        [XmlElement("answer")]
        public string Answer { get; set; }

        /// <summary>
        /// 流式回答关联ID, 用于关联流失回答中一组完整的回答内容
        /// </summary>
        [XmlElement("answer_flow_id")]
        public string AnswerFlowId { get; set; }

        /// <summary>
        /// 目前只支持纯文本：PLAINTEXT
        /// </summary>
        [XmlElement("answer_format")]
        public string AnswerFormat { get; set; }

        /// <summary>
        /// 正常回答: NORMAL 流式回答: FLOW
        /// </summary>
        [XmlElement("answer_type")]
        public string AnswerType { get; set; }

        /// <summary>
        /// 扩展属性Map，key限定为：aigcType、serviceScene、triggerSource、bizOwner，对应的value取值为：  aigcType：  ● 文生文：text_text  ● 文生图：text_pic  ● 图生文：pic_text  ● 图生图：pic_pic   serviceScene: 根据业务使用的不同情况支持自定义入参做策略个性化配置，私域或者公域，以及不同的业务应用 比如领域： serviceScene = insurance 表示保险 serviceScene = medical 表示医疗 serviceScene = government 表示政务 比如业务活动应用： serviceScene = xiacu 表示夏促 serviceScene = qixi 表示七夕   triggerSource:  不同的来源，比如移动端、web端、API
        /// </summary>
        [XmlElement("business_properties")]
        public KeyValueMap BusinessProperties { get; set; }

        /// <summary>
        /// 大模型ID，表示大模型类型和版本等
        /// </summary>
        [XmlElement("model_code")]
        public string ModelCode { get; set; }

        /// <summary>
        /// 当前提问内容，最大长度800个字符。
        /// </summary>
        [XmlElement("question")]
        public string Question { get; set; }

        /// <summary>
        /// 当前只支持纯文本：PLAINTEXT
        /// </summary>
        [XmlElement("question_format")]
        public string QuestionFormat { get; set; }

        /// <summary>
        /// 数据唯一标识，能够根据该值定位到该条数据
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 大模型提问护栏服务, 用于区分提供的服务类别，当前支持：TJ_QUESTION_BASIC、TJ_ANSWER_BASIC 两种
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 会话ID，用于匹配多轮对话上下文
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 用户ID，用于主体风险判断，如为2088阿里体系用户，建议传入2088相关账户
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
