using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudTraasContentTextDetectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudTraasContentTextDetectModel : AopObject
    {
        /// <summary>
        /// 用户发表内容，建议对内容中的格式符号、表情符、HTML标签、UBB标签等做过滤，只传递纯文本，以减少误判。此字段和text_type相关，短文本（short）：短文本发表内容长度范围：[1,200] 长文本（long）：长文本发表内容长度范围：[1,10000]
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("string")]
        public List<string> DataList { get; set; }

        /// <summary>
        /// 支付宝用户openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 唯一请求ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 文本类型 注：当前版本只支持短文本检测
        /// </summary>
        [XmlElement("text_type")]
        public string TextType { get; set; }

        /// <summary>
        /// 用于输入用户支付宝的 2088 账号，如不了解此字段如何获取，可了解下静默授权。如参数无法提供，请填写“null”字符串
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
