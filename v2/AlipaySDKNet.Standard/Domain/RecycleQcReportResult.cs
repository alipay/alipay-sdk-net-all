using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleQcReportResult Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleQcReportResult : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("image_id_list")]
        [XmlArrayItem("string")]
        public List<string> ImageIdList { get; set; }

        /// <summary>
        /// option_code是问卷中的问题选项code，和text二选一传入 使用支付宝问卷问题时，传入option_code；非支付宝问卷，传入text
        /// </summary>
        [XmlElement("option_code")]
        public string OptionCode { get; set; }

        /// <summary>
        /// 文案
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
