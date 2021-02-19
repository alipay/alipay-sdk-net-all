using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotReceiptSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotReceiptSendModel : AopObject
    {
        /// <summary>
        /// 用户支付宝uid
        /// </summary>
        [XmlElement("alipay_uid")]
        public string AlipayUid { get; set; }

        /// <summary>
        /// 电子小票详情信息
        /// </summary>
        [XmlElement("biz_data")]
        public ReceiptBizData BizData { get; set; }

        /// <summary>
        /// 机具身份id
        /// </summary>
        [XmlElement("biztid")]
        public string Biztid { get; set; }

        /// <summary>
        /// 直联商户填写pid，  pid和smid必填其一
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 间联商户填写smid，pid和smid必填其一
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
