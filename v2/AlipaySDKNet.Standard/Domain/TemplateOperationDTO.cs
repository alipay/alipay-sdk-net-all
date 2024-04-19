using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TemplateOperationDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateOperationDTO : AopObject
    {
        /// <summary>
        /// 核销区行动点提示文案。支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [XmlElement("alt_text")]
        public string AltText { get; set; }

        /// <summary>
        /// 核销操作类型，支持：qrcode（二维码方式）、barcode（条形码）、text（文本文案）、url（网页链接）、自定义核销（exchange）。支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [XmlElement("format_type")]
        public string FormatType { get; set; }

        /// <summary>
        /// 核销区具体行动，当核销操作类型为：qrcode（二维码方式）、barcode（条形码）、自定义核销（exchange）时为具体核销操作值；当核销操作类型为：url（网页链接）时为对应跳转服务地址，需带上http、https、alipays等协议头。支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 核销区提示信息标准编码格式，如gbk、utf-8（默认）等。支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [XmlElement("message_encoding")]
        public string MessageEncoding { get; set; }

        /// <summary>
        /// 核销区文本信息描述，当核销操作类型为：text（文本文案）时必填，用于描述具体文本文案内容。
        /// </summary>
        [XmlArray("text_messages")]
        [XmlArrayItem("template_text_message_d_t_o")]
        public List<TemplateTextMessageDTO> TextMessages { get; set; }
    }
}
