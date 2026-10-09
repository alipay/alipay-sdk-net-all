using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniCloudAossuggestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniCloudAossuggestQueryModel : AopObject
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
        /// 用户的输入
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// 期待返回的热搜结果数量，返回的热搜条数，默认5，(0,10]
        /// </summary>
        [XmlElement("size")]
        public long Size { get; set; }

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
