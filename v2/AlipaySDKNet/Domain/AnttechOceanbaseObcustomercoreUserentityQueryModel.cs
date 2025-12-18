using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObcustomercoreUserentityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObcustomercoreUserentityQueryModel : AopObject
    {
        /// <summary>
        /// 搜索类型：COMPANY-企业，PERSONAL-个人，INSTITUTION-机构
        /// </summary>
        [XmlElement("entity_type")]
        public string EntityType { get; set; }

        /// <summary>
        /// 客户名称（支持企业名称和个人名称）
        /// </summary>
        [XmlElement("eq_name")]
        public string EqName { get; set; }

        /// <summary>
        /// 用于传入查询的当前页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 用于设置查询的每页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
