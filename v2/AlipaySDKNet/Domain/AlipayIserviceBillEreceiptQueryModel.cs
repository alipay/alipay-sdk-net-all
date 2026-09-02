using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceBillEreceiptQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceBillEreceiptQueryModel : AopObject
    {
        /// <summary>
        /// 回单文件ID。由申请电子章回单接口返回。
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }
    }
}
