using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalAqdualchannelMsgSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalAqdualchannelMsgSendModel : AopObject
    {
        /// <summary>
        /// 支付宝uid，2088开头的16位纯数字，小程序场景下获取用户ID请参考：用户授权; 其它场景下获取用户ID请参考：网页授权获取用户信息;
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 支付宝uid，2088开头的16位纯数字，小程序场景下获取用户ID请参考：用户授权; 其它场景下获取用户ID请参考：网页授权获取用户信息;
        /// </summary>
        [XmlElement("alipay_user_open_id")]
        public string AlipayUserOpenId { get; set; }

        /// <summary>
        /// 安诊儿消息发送配置
        /// </summary>
        [XmlElement("azr_msg_send")]
        public bool AzrMsgSend { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        [XmlElement("msg_context")]
        public string MsgContext { get; set; }

        /// <summary>
        /// 订单创建时间，时间格式为：yyyy-mm-dd hh:mm:ss
        /// </summary>
        [XmlElement("msg_create_time")]
        public string MsgCreateTime { get; set; }

        /// <summary>
        /// 订单修改时间，时间格式为：yyyy-mm-dd hh:mm:ss
        /// </summary>
        [XmlElement("msg_modified_time")]
        public string MsgModifiedTime { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        [XmlElement("org_id")]
        public string OrgId { get; set; }

        /// <summary>
        /// 商户订单id，保持唯一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 模板码，支付宝侧定义
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }

        /// <summary>
        /// 用户证件号
        /// </summary>
        [XmlElement("user_card_no")]
        public string UserCardNo { get; set; }

        /// <summary>
        /// 用户证件类型
        /// </summary>
        [XmlElement("user_card_type")]
        public string UserCardType { get; set; }
    }
}
