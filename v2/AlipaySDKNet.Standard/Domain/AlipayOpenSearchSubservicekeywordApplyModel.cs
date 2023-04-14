using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSearchSubservicekeywordApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSearchSubservicekeywordApplyModel : AopObject
    {
        /// <summary>
        /// 关键词id，（仅修改时传入，修改时仅能传一个关键词）
        /// </summary>
        [XmlElement("config_id")]
        public string ConfigId { get; set; }

        /// <summary>
        /// 关键词，提报服务关键词，人工录入
        /// </summary>
        [XmlArray("key_words")]
        [XmlArrayItem("string")]
        public List<string> KeyWords { get; set; }

        /// <summary>
        /// 子服务code，提报服务关键词，alipay.open.app.service.list.query(服务批量查询)这个接口可以获取
        /// </summary>
        [XmlElement("sub_service_code")]
        public string SubServiceCode { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("target_appid")]
        public string TargetAppid { get; set; }
    }
}
