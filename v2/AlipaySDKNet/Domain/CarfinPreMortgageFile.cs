using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarfinPreMortgageFile Data Structure.
    /// </summary>
    [Serializable]
    public class CarfinPreMortgageFile : AopObject
    {
        /// <summary>
        /// 文件在支付宝的aftsid
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 文件类型： 10201 —— 抵押/解除抵押申请表 PDF 文件 10202 ——所有人身份证正反面原件 10215 —— 抵押合同 PDF 文件 10273 —— 抵押权人委托书文件 10258 —— 车主委托书
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
