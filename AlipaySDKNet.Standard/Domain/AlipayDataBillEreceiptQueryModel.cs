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
        /// 根据申请id查询状态。通过 <a href="https://opendocs.alipay.com/apis/api_15/alipay.data.bill.ereceipt.apply">alipay.data.bill.ereceipt.apply(申请电子回单(incubating))</a>接口同步响应获取。
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }
    }
}
