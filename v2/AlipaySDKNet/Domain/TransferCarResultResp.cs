using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TransferCarResultResp Data Structure.
    /// </summary>
    [Serializable]
    public class TransferCarResultResp : AopObject
    {
        /// <summary>
        /// 对应外部 id 的处理结果
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 外部id值
        /// </summary>
        [XmlElement("out_id")]
        public string OutId { get; set; }

        /// <summary>
        /// 处理结果 boolean true/false
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
