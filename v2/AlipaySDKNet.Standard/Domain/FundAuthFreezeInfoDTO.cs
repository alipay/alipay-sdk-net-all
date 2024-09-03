using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FundAuthFreezeInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class FundAuthFreezeInfoDTO : AopObject
    {
        /// <summary>
        /// 芝麻外部类目
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 资金预授权成功消息通知地址，接入租赁快捷下单商户可通过指定该地址监听支付宝侧预授权消息
        /// </summary>
        [XmlElement("freeze_notify_url")]
        public string FreezeNotifyUrl { get; set; }

        /// <summary>
        /// 收款账户的支付宝用户号。 以2088开头的16位纯数字，如果传入则会校验该账号是否具备当前商户收款权限，
        /// </summary>
        [XmlElement("payee_user_id")]
        public string PayeeUserId { get; set; }

        /// <summary>
        /// 芝麻侧生成的信用服务id
        /// </summary>
        [XmlElement("zm_service_id")]
        public string ZmServiceId { get; set; }
    }
}
