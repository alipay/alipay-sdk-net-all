using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TechriskInnovateMpcpromoDataDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class TechriskInnovateMpcpromoDataDeleteModel : AopObject
    {
        /// <summary>
        /// 商品列表ids
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("string")]
        public List<string> DataList { get; set; }

        /// <summary>
        /// 数据类型
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }
    }
}
