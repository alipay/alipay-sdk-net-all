using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CodeExtBean Data Structure.
    /// </summary>
    [Serializable]
    public class CodeExtBean : AopObject
    {
        /// <summary>
        /// 渠道信息
        /// </summary>
        [XmlElement("ch_info")]
        public string ChInfo { get; set; }

        /// <summary>
        /// 码TOKEN
        /// </summary>
        [XmlElement("code_token")]
        public string CodeToken { get; set; }

        /// <summary>
        /// 码类型
        /// </summary>
        [XmlElement("code_type")]
        public string CodeType { get; set; }

        /// <summary>
        /// 桌号
        /// </summary>
        [XmlElement("table_name")]
        public string TableName { get; set; }
    }
}
