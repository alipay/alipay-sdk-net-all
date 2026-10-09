using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentCarGuaranteeSubDetailDescription Data Structure.
    /// </summary>
    [Serializable]
    public class RentCarGuaranteeSubDetailDescription : AopObject
    {
        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 表格信息
        /// </summary>
        [XmlArray("table")]
        [XmlArrayItem("rent_car_table_info")]
        public List<RentCarTableInfo> Table { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
