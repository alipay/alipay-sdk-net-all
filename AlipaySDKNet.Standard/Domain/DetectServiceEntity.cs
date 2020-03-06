using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DetectServiceEntity Data Structure.
    /// </summary>
    [Serializable]
    public class DetectServiceEntity : AopObject
    {
        /// <summary>
        /// 业务唯一id，如迭代id等
        /// </summary>
        [XmlElement("biz_uniq_id")]
        public string BizUniqId { get; set; }

        /// <summary>
        /// 该字段可选
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 固定为oblisk_detect_instant
        /// </summary>
        [XmlArray("detect_type_list")]
        [XmlArrayItem("string")]
        public List<string> DetectTypeList { get; set; }

        /// <summary>
        /// 扩展信息。JSON字符串。如果是小程序，则必须传version属性。必须
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 该字段可选
        /// </summary>
        [XmlArray("pic_url_list")]
        [XmlArrayItem("string")]
        public List<string> PicUrlList { get; set; }

        /// <summary>
        /// 服务url。必须。     1）如果是整个小程序的诊断(伙伴、云测都是此种情况),传appId|version，如.2019082366379626|2.5.33   2）如果是某个小程序页面的诊断,传该页面的具体路径: alipays://platformapi/startapp?appId=2018091261350219&page=/pages/h5pages/h5pages  3）如果是H5,传url, 如https://www.baidu.com
        /// </summary>
        [XmlElement("service")]
        public string Service { get; set; }

        /// <summary>
        /// 小程序名称，或者H5服务名称。必须。
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
