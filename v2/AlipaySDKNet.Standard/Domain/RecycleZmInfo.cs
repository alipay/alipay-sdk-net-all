using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleZmInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleZmInfo : AopObject
    {
        /// <summary>
        /// 当用户进入芝麻先享下单页面后，点击左上角的回退按钮，中断开通流程，跳转回商户地址，该字段代表跳转回商家的页面地址。
        /// </summary>
        [XmlElement("cancel_back_link")]
        public string CancelBackLink { get; set; }

        /// <summary>
        /// 是否使用芝麻先享
        /// </summary>
        [XmlElement("enable")]
        public bool Enable { get; set; }

        /// <summary>
        /// 用户芝麻先享开通并下单流程结束后，不区分用户开通并下单成功/失败，跳转回商家页面，该字段代表跳转回商家的页面地址。
        /// </summary>
        [XmlElement("return_back_link")]
        public string ReturnBackLink { get; set; }
    }
}
