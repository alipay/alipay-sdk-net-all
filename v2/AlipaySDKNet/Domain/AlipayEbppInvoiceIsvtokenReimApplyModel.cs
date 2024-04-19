using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceIsvtokenReimApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceIsvtokenReimApplyModel : AopObject
    {
        /// <summary>
        /// 报销软件app对应的isv app code，由支付宝进行分配。详情参见 <a href="https://opendocs.alipay.com/open/017fwh">"推"模式发票报销</a>
        /// </summary>
        [XmlElement("isv_app_code")]
        public string IsvAppCode { get; set; }
    }
}
