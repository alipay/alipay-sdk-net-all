using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicOdpsCrowdSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicOdpsCrowdSyncModel : AopObject
    {
        /// <summary>
        /// 人群来源渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 人群名称，不能包含特殊字符
        /// </summary>
        [XmlElement("crowd_name")]
        public string CrowdName { get; set; }

        /// <summary>
        /// 即离线数据分区，多级分区时，为list格式
        /// </summary>
        [XmlArray("data_partition")]
        [XmlArrayItem("string")]
        public List<string> DataPartition { get; set; }

        /// <summary>
        /// 字段名称，账户类型非ALIPAY_USER 时必填
        /// </summary>
        [XmlElement("field_name")]
        public string FieldName { get; set; }

        /// <summary>
        /// 集团人群id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 数据odps表单名称,格式：project.tablename
        /// </summary>
        [XmlElement("table_name")]
        public string TableName { get; set; }

        /// <summary>
        /// 用户类型，支付宝账户:ALIPAY_USER,淘宝账户:TAOBAO_USER
        /// </summary>
        [XmlElement("user_type")]
        public string UserType { get; set; }
    }
}
