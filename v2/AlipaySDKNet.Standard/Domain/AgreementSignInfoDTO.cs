using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AgreementSignInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AgreementSignInfoDTO : AopObject
    {
        /// <summary>
        /// 用户个人协议签约消息通知地址，接入租赁快捷下单商户可通过指定该地址监听支付宝侧用户个人协议签约成功消息
        /// </summary>
        [XmlElement("sign_notify_url")]
        public string SignNotifyUrl { get; set; }

        /// <summary>
        /// 签约成功后的跳转页面地址
        /// </summary>
        [XmlElement("sign_return_url")]
        public string SignReturnUrl { get; set; }
    }
}
