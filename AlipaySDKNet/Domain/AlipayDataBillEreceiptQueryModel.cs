using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataBillEreceiptQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataBillEreceiptQueryModel : AopObject
    {
        /// <summary>
        /// 根据申请id查询状态
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }
    }
}
