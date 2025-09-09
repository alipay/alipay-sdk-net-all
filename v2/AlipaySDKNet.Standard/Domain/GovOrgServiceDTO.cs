using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GovOrgServiceDTO Data Structure.
    /// </summary>
    [Serializable]
    public class GovOrgServiceDTO : AopObject
    {
        /// <summary>
        /// 服务的展示渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 城市编码。多个城市编码用英文逗号隔开。 如330100,330200
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 用于描述服务能力范围，详细的服务描述更有利于大模型识别召回
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 用户服务展示时的logo图
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 用于查询公积金余额
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 外部服务id。需要调用机构保证唯一性
        /// </summary>
        [XmlElement("out_service_id")]
        public string OutServiceId { get; set; }

        /// <summary>
        /// 语料运行状态
        /// </summary>
        [XmlElement("run_status")]
        public string RunStatus { get; set; }

        /// <summary>
        /// 服务提供方
        /// </summary>
        [XmlElement("supplier")]
        public string Supplier { get; set; }

        /// <summary>
        /// 服务跳转链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
