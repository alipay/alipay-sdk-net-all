using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CategoryInfoModel Data Structure.
    /// </summary>
    [Serializable]
    public class CategoryInfoModel : AopObject
    {
        /// <summary>
        /// 商家主营类目
        /// </summary>
        [XmlElement("main_name")]
        public string MainName { get; set; }

        /// <summary>
        /// 商家经营子类目名称列表
        /// </summary>
        [XmlArray("name_list")]
        [XmlArrayItem("string")]
        public List<string> NameList { get; set; }
    }
}
