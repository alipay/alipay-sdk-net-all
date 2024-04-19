using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSearchAppkeywordApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSearchAppkeywordApplyModel : AopObject
    {
        /// <summary>
        /// 关键词配置id，由支付宝生成，关键词申请通过后会通知接口返回，也可以申请单状态获取
        /// </summary>
        [XmlElement("config_id")]
        public string ConfigId { get; set; }

        /// <summary>
        /// 提报的关键词
        /// </summary>
        [XmlArray("key_words")]
        [XmlArrayItem("string")]
        public List<string> KeyWords { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("target_appid")]
        public string TargetAppid { get; set; }
    }
}
