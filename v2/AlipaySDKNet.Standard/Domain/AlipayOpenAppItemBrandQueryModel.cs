using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppItemBrandQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppItemBrandQueryModel : AopObject
    {
        /// <summary>
        /// 类目ID，查询类目信息获取类目ID 
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 分页查询的页码。默认从1开始
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询的每页记录数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 品牌前缀（中文或者英文），根据前缀搜索品牌
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }
    }
}
