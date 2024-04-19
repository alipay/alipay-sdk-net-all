using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataBillAccountbookereceiptQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataBillAccountbookereceiptQueryModel : AopObject
    {
        /// <summary>
        /// 协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 根据申请id查询状态
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }
    }
}
