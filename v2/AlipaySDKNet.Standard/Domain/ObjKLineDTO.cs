using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ObjKLineDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ObjKLineDTO : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("k_line_list_d_t_o")]
        public List<KLineListDTO> List { get; set; }

        /// <summary>
        /// K线周期类型:   // 1 分钟   P_Min1     // 5 分钟       P_Min5     // 15 分钟     P_Min15     // 30 分钟      P_Min30     // 60 分钟       P_Min60     // 日      P_Day1     // 周      P_Week1     // 月      P_Month1
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }

        /// <summary>
        /// * 复权类型      * 前复权   =  S_Before      * 后复权   =  S_After      * 不复权   =  S_Unsplit
        /// </summary>
        [XmlElement("split")]
        public string Split { get; set; }

        /// <summary>
        /// 股票代码
        /// </summary>
        [XmlElement("symbol")]
        public string Symbol { get; set; }
    }
}
