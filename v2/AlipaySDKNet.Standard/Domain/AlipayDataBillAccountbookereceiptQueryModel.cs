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
        /// 协议号，根据不同业务协议类型，传入对应类型的协议号，用于isv授权检查并获取商户信息。如果业务类型未指定，则使用默认类型对应的协议号。
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 根据不同业务协议类型，传入不同参数。传入协议产品码（personal_product_code，通过协议查询接口、协议签约通知响应参数获取），不填的话默认按照示例值传入
        /// </summary>
        [XmlElement("agreement_type")]
        public string AgreementType { get; set; }

        /// <summary>
        /// 根据申请id查询状态。申请接口可以参考alipay.data.bill.ereceiptagent.apply
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }
    }
}
