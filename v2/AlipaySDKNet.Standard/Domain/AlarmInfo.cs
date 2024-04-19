using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlarmInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AlarmInfo : AopObject
    {
        /// <summary>
        /// 6位国标码，支持传区县+城市级别 和ad_code_list任选其一填写
        /// </summary>
        [XmlElement("ad_code")]
        public string AdCode { get; set; }

        /// <summary>
        /// adCode列表。支持省份，城市，区县维度。和adCode参数任选其一填写
        /// </summary>
        [XmlArray("ad_code_list")]
        [XmlArrayItem("string")]
        public List<string> AdCodeList { get; set; }

        /// <summary>
        /// 天气预警描述信息
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 预警结束时间。如果有预期结束时间可以填写。如果没有系统会自动计算个默认失效时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 预警级别，一般包含蓝色，黄色，橙色，红色
        /// </summary>
        [XmlElement("level")]
        public string Level { get; set; }

        /// <summary>
        /// 天气预警唯一id
        /// </summary>
        [XmlElement("out_id")]
        public string OutId { get; set; }

        /// <summary>
        /// 预警承接页链接。如果自行开发了承接页面，请传入该链接
        /// </summary>
        [XmlElement("target_url")]
        public string TargetUrl { get; set; }

        /// <summary>
        /// 标准时间格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("time")]
        public string Time { get; set; }

        /// <summary>
        /// 天气预警的标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 天气预警类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
