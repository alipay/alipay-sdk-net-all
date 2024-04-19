using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneQuotationQuoteinfoprodNlqueryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneQuotationQuoteinfoprodNlqueryQueryModel : AopObject
    {
        /// <summary>
        /// 应用标识，需要与接口人确定后赋予
        /// </summary>
        [XmlElement("app_token")]
        public string AppToken { get; set; }

        /// <summary>
        /// file path
        /// </summary>
        [XmlElement("file_path")]
        public string FilePath { get; set; }

        /// <summary>
        /// 具体的请求参数值，目前是日期
        /// </summary>
        [XmlElement("param")]
        public string Param { get; set; }

        /// <summary>
        /// 大语言模型请求的文本内容，不固定
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        [XmlElement("task_type")]
        public string TaskType { get; set; }
    }
}
