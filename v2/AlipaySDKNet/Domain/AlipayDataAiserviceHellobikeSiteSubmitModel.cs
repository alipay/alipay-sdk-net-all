using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataAiserviceHellobikeSiteSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataAiserviceHellobikeSiteSubmitModel : AopObject
    {
        /// <summary>
        /// 接口版本号
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 待输出城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 期望输出日期：YYYY-MM-DD
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 禁停区域
        /// </summary>
        [XmlArray("exc_fence")]
        [XmlArrayItem("string")]
        public List<string> ExcFence { get; set; }

        /// <summary>
        /// 禁用poi
        /// </summary>
        [XmlArray("exc_poi")]
        [XmlArrayItem("string")]
        public List<string> ExcPoi { get; set; }

        /// <summary>
        /// 拓展字段
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 运营区围栏
        /// </summary>
        [XmlArray("fence")]
        [XmlArrayItem("string")]
        public List<string> Fence { get; set; }

        /// <summary>
        /// 站点缺口
        /// </summary>
        [XmlElement("num")]
        public long Num { get; set; }

        /// <summary>
        /// 推荐poi
        /// </summary>
        [XmlArray("rec_poi")]
        [XmlArrayItem("string")]
        public List<string> RecPoi { get; set; }

        /// <summary>
        /// 站点大小：长cm*宽cm
        /// </summary>
        [XmlElement("size")]
        public string Size { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 枚举：0 助力车站点/ 1 单车站点/ 2 其他
        /// </summary>
        [XmlElement("type")]
        public long Type { get; set; }
    }
}
