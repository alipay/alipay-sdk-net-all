using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TechriskInnovateMpcpromoDataModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class TechriskInnovateMpcpromoDataModifyModel : AopObject
    {
        /// <summary>
        /// 需要新增的数据，结构为二维数组。 如：[["艾尼","是"],["拉克","否"]]
        /// </summary>
        [XmlArray("add_data_list")]
        [XmlArrayItem("column_data")]
        public List<ColumnData> AddDataList { get; set; }

        /// <summary>
        /// 需要删除的数据，结构为二维数组。  如：[["简妮","否"],["拉瑞","是"]]
        /// </summary>
        [XmlArray("del_data_list")]
        [XmlArrayItem("column_data")]
        public List<ColumnData> DelDataList { get; set; }

        /// <summary>
        /// 商户之前导入的文件名称。
        /// </summary>
        [XmlElement("filename")]
        public string Filename { get; set; }

        /// <summary>
        /// 列名列表
        /// </summary>
        [XmlArray("row_info_list")]
        [XmlArrayItem("string")]
        public List<string> RowInfoList { get; set; }
    }
}
