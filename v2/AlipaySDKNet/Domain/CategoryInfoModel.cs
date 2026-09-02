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
        /// 主营类目编码信息，代表店铺主类目信息
        /// </summary>
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 商家主营类目
        /// </summary>
        [XmlElement("main_name")]
        public string MainName { get; set; }

        /// <summary>
        /// 商家经营子类目名称列表 当前字段已废弃(业务调整，该参数不在使用)
        /// </summary>
        [XmlArray("name_list")]
        [XmlArrayItem("string")]
        public List<string> NameList { get; set; }
    }
}
