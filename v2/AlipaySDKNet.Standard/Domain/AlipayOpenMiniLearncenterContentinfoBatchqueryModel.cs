using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniLearncenterContentinfoBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniLearncenterContentinfoBatchqueryModel : AopObject
    {
        /// <summary>
        /// 内容分类，最大长度32个字符。不传入默认查询学习课堂内容。 默认值：course。
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 分页查询页码，不传默认查询第一页数据。 默认值：1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }
    }
}
