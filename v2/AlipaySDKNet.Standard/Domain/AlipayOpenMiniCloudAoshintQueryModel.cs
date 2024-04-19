using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniCloudAoshintQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniCloudAoshintQueryModel : AopObject
    {
        /// <summary>
        /// 用户当前城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 客户端环境
        /// </summary>
        [XmlElement("client_env")]
        public string ClientEnv { get; set; }

        /// <summary>
        /// 用户设备id
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 用户唯一标识id，可以是支付宝userid、商家自定义的userid等
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商家在蚂蚁搜索引擎创建的项目id，调用前需要找蚂蚁技术获取。
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 默认值5，hit范围：(0,10]
        /// </summary>
        [XmlElement("size")]
        public string Size { get; set; }

        /// <summary>
        /// default：默认热搜结果，pv：查询pv最高的热搜，uv：查询uv最高的热搜
        /// </summary>
        [XmlElement("sort_type")]
        public string SortType { get; set; }

        /// <summary>
        /// 用户唯一标识id，可以是支付宝userid、商家自定义的userid等
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户id的类型，可选值：ALIPAY（支付宝userid）、CUSTOM（商家自定义的userid）
        /// </summary>
        [XmlElement("user_id_type")]
        public string UserIdType { get; set; }
    }
}
