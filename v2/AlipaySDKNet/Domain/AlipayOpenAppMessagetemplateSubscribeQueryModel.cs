using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppMessagetemplateSubscribeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppMessagetemplateSubscribeQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝openId，用于支付宝用户在当前应用下的用户标识。
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 消息模板id，可以填写多个，最多不超过3个。模板id需要保持同一个应用主体，并且展示在同一个订阅组件中的模板id。 模板id获取详情参见<a href="https://opendocs.alipay.com/mini/01rnqx">模板消息</a>。
        /// </summary>
        [XmlArray("template_id_list")]
        [XmlArrayItem("string")]
        public List<string> TemplateIdList { get; set; }

        /// <summary>
        /// 订阅消息模板用户的支付宝唯一标识，2088开头。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
