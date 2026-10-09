using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniCloudAosbizdataSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniCloudAosbizdataSyncModel : AopObject
    {
        /// <summary>
        /// 应用身份标识id
        /// </summary>
        [XmlElement("app_token")]
        public string AppToken { get; set; }

        /// <summary>
        /// 数据
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("aos_data_item")]
        public List<AosDataItem> Data { get; set; }

        /// <summary>
        /// 业务id类型
        /// </summary>
        [XmlElement("id_type")]
        public string IdType { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [XmlElement("ops")]
        public string Ops { get; set; }

        /// <summary>
        /// 时间戳字段
        /// </summary>
        [XmlElement("ops_timestamp")]
        public string OpsTimestamp { get; set; }

        /// <summary>
        /// 数据类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
