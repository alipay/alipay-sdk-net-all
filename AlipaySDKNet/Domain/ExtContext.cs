using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExtContext Data Structure.
    /// </summary>
    [Serializable]
    public class ExtContext : AopObject
    {
        /// <summary>
        /// ebank_form，银行返回格式类型
        /// </summary>
        [XmlElement("ebank_form")]
        public string EbankForm { get; set; }

        /// <summary>
        /// 机构返回描述
        /// </summary>
        [XmlElement("return_message")]
        public string ReturnMessage { get; set; }
    }
}
