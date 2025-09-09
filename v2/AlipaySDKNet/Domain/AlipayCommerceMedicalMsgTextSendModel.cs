using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMsgTextSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMsgTextSendModel : AopObject
    {
        /// <summary>
        /// 支付宝uid 2088开头的16位纯数字，小程序场景下获取用户ID请参考：用户授权; 其它场景下获取用户ID请参考：网页授权获取用户信息;
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 业务主体，可选值如下（可增加）： ● agent_text：智能体短信
        /// </summary>
        [XmlElement("biz_principal")]
        public string BizPrincipal { get; set; }

        /// <summary>
        /// 消息内容中的变量数据 <a href="https://message.alipay.com/allMessage">消息运营平台</a> 中查看具体数据
        /// </summary>
        [XmlElement("msg_content")]
        public string MsgContent { get; set; }

        /// <summary>
        /// 消息的产生时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("msg_create_time")]
        public string MsgCreateTime { get; set; }

        /// <summary>
        /// 消息的修改时间，格式yyyy-MM-dd HH:mm:ss 如果不传，默认和消息产生时间相同
        /// </summary>
        [XmlElement("msg_modified_time")]
        public string MsgModifiedTime { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 医院对应的orgId
        /// </summary>
        [XmlElement("org_id")]
        public string OrgId { get; set; }

        /// <summary>
        /// 外部业务id请保持唯一，调用方自生成
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 发送短信的手机号码
        /// </summary>
        [XmlElement("phone_no")]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 消息模板id 支付宝侧定义 <a href="https://message.alipay.com/allMessage"> 消息运营平台</a> 中你配置的模板的消息id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
