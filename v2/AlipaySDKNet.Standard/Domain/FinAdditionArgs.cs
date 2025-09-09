using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FinAdditionArgs Data Structure.
    /// </summary>
    [Serializable]
    public class FinAdditionArgs : AopObject
    {
        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 选择的文件ID列表
        /// </summary>
        [XmlArray("selected_files")]
        [XmlArrayItem("string")]
        public List<string> SelectedFiles { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 标的列表
        /// </summary>
        [XmlArray("symbol_list")]
        [XmlArrayItem("fin_symbol_detail")]
        public List<FinSymbolDetail> SymbolList { get; set; }
    }
}
