using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentCarGuaranteeDetailDescription Data Structure.
    /// </summary>
    [Serializable]
    public class RentCarGuaranteeDetailDescription : AopObject
    {
        /// <summary>
        /// 是否包含该服务
        /// </summary>
        [XmlElement("contains")]
        public bool Contains { get; set; }

        /// <summary>
        /// 内容列表，每项一行
        /// </summary>
        [XmlArray("content")]
        [XmlArrayItem("string")]
        public List<string> Content { get; set; }

        /// <summary>
        /// 子内容
        /// </summary>
        [XmlArray("sub_content")]
        [XmlArrayItem("rent_car_guarantee_sub_detail_description")]
        public List<RentCarGuaranteeSubDetailDescription> SubContent { get; set; }

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
