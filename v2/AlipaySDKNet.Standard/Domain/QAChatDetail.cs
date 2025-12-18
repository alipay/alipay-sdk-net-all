using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QAChatDetail Data Structure.
    /// </summary>
    [Serializable]
    public class QAChatDetail : AopObject
    {
        /// <summary>
        /// 机器人回答详情
        /// </summary>
        [XmlElement("answer")]
        public RobotAnswer Answer { get; set; }

        /// <summary>
        /// DOCUMENT:大模型文档问答； KNOWLEDGE：知识点问答； DST：多轮问答； SORRY：致歉语；BUBBLE : 气泡；LARGE_MODEL：大模型；ST_CHAT ：闲聊
        /// </summary>
        [XmlElement("answer_type")]
        public string AnswerType { get; set; }

        /// <summary>
        /// 本次机器人回答的id
        /// </summary>
        [XmlElement("chat_uuid")]
        public string ChatUuid { get; set; }

        /// <summary>
        /// 用来标识告知国泰侧，当前会话记录归属哪个对应组件 出参不传此字段时，当作默认文件chat交互处理，如果传了此字段，标识当前记录属于组件交互会话的场景，可根据此字段的值判断当前内容属于哪个组件，从而对记录进行渲染 示例： 1.VERIFY_USER_CERT_LAST_6_CODE 身份证后6位核身组件 2.VERIFY_USER_CERT 身份证/保单号核身组件 3.VERIFY_USER_LICENSE_PLATE_NO 车牌号/车架号核身组件 4.POLICY_INQUIRY 保单查询组件 5.POLICY_SINGLE_OPTIONS 保单选择单选组件 6.POLICY_MULTIPLE_OPTIONS 保单选择多选组件 7.CLAIM_CASE_SINGLE_OPTIONS 赔案选择单选组件 8.CLAIM_CASE_MULTIPLE_OPTIONS 赔案选择多选组件 9.CORPORATE_INVOICE_FILLING 企业发票填写组件 10.PERSONAL_INVOICE_FILLING 个人发票填写组件 11.ELECTRONIC_POLICY 接收电子保单组件 12.WORK_ORDER_CONSULTATION_OPTIONS 工单咨询组件 13.WORK_ORDER_URGE_REMARK 工单备注/催办组件 14.WORK_ORDER_REMARK 工单备注组件 15.CLAIM_SETTLEMENT_PROGRESS 理赔催进度组件 16.CLAIM_SETTLEMENT_PROGRESS_PHONE 理赔催进度提交手机号组件
        /// </summary>
        [XmlElement("component_code")]
        public string ComponentCode { get; set; }

        /// <summary>
        /// 数据创建时间
        /// </summary>
        [XmlElement("local_timestamp")]
        public string LocalTimestamp { get; set; }

        /// <summary>
        /// 问题内容
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// 未评价:0 好评:1 差评:-1
        /// </summary>
        [XmlElement("vote_type")]
        public string VoteType { get; set; }
    }
}
