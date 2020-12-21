using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmRolePageQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmRolePageQueryModel : AopObject
    {
        /// <summary>
        /// 部门id（即租户实例ID、数据权限ID）
        /// </summary>
        [XmlElement("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 查询结果的页码，起始值为 1，默认值为 1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询时设置的每页记录数，最大值 100 行，默认为 10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
