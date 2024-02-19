using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppMiniTemplatemessageSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppMiniTemplatemessageSendModel : AopObject
    {
        /// <summary>
        /// 模板消息内容。商家/开发者将模板占位符替换为自定义内容
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 支付消息模板：需传入用户发生的交易行为的支付宝交易号 trade_no；</br>表单提交模板：需传入用户在小程序触发表单提交事件获得的表单号；</br>刷脸消息模板：需传入在IOT刷脸后得到的ftoken等，用于信息发送的校验。</br>说明：订阅消息模板无需传入本参数。
        /// </summary>
        [XmlElement("form_id")]
        public string FormId { get; set; }

        /// <summary>
        /// 小程序的跳转页面。用于用户点击模板消息 进入小程序查看 按钮后，跳转至商家小程序对应页面。
        /// </summary>
        [XmlElement("page")]
        public string Page { get; set; }

        /// <summary>
        /// 支付宝openId，用于支付宝用户在当前应用下的用户标识。
        /// </summary>
        [XmlElement("to_open_id")]
        public string ToOpenId { get; set; }

        /// <summary>
        /// 接收模板消息用户支付宝 user_id，可通过 <a href="https://opendocs.alipay.com/mini/api/openapi-authorize">用户授权</a> 获取
        /// </summary>
        [XmlElement("to_user_id")]
        public string ToUserId { get; set; }

        /// <summary>
        /// 商家在商家自运营中心选用的消息模板ID，详情参见 <a href="https://opendocs.alipay.com/mini/01rnqx#%E8%AE%A2%E9%98%85%E6%B6%88%E6%81%AF">选用消息模板</a> 。
        /// </summary>
        [XmlElement("user_template_id")]
        public string UserTemplateId { get; set; }
    }
}
