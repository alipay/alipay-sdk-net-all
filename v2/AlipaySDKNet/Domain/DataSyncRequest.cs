using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DataSyncRequest Data Structure.
    /// </summary>
    [Serializable]
    public class DataSyncRequest : AopObject
    {
        /// <summary>
        /// 业务唯一键，格式为tenant_type_id
        /// </summary>
        [XmlElement("biz_key")]
        public string BizKey { get; set; }

        /// <summary>
        /// 数据内容
        /// </summary>
        [XmlElement("data_content")]
        public string DataContent { get; set; }

        /// <summary>
        /// 数据类型
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 分区时间，格式"yyyyMMdd"
        /// </summary>
        [XmlElement("dt")]
        public string Dt { get; set; }
    }
}
