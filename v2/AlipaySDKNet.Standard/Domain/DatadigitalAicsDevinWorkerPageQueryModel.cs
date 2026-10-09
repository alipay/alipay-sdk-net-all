using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalAicsDevinWorkerPageQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalAicsDevinWorkerPageQueryModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("code_list")]
        [XmlArrayItem("string")]
        public List<string> CodeList { get; set; }

        /// <summary>
        /// 数字员工名称，非空时模糊查询
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 当前页码，默认1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页条数，默认10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 是否有效：0-无效 1-有效，非空时精确过滤
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }

        /// <summary>
        /// 类型，默认aiworker，非空时精确过滤
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 版本类型：空=不过滤；simple=极致版；其他非空值查version_type IS NULL(旧版数据)
        /// </summary>
        [XmlElement("version_type")]
        public string VersionType { get; set; }
    }
}
