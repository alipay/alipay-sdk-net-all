using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CategoryInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CategoryInfoDTO : AopObject
    {
        /// <summary>
        /// 服务商可使用的场景类目
        /// </summary>
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }
    }
}
