using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialOpengreenEnergyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialOpengreenEnergyQueryModel : AopObject
    {
        /// <summary>
        /// 生成能量时传入的唯一键
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 查询结束时间，选填
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 选填，后续有特殊需求，可以存放的字段
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 传入需要查询的绿色场景字符串数组
        /// </summary>
        [XmlArray("green_actions")]
        [XmlArrayItem("string")]
        public List<string> GreenActions { get; set; }

        /// <summary>
        /// 在对应商户的消费者id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户接入绿色开发平台的id
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 请求的来源，必填
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 查询开始时间，查询区域最大只支持3个月，包含当月
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
