using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundMbpcardGencardCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundMbpcardGencardCreateModel : AopObject
    {
        /// <summary>
        /// 购卡交易的业务单号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 外部请求单号，调用系统生成，幂等参数；
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 购卡交易方式
        /// </summary>
        [XmlElement("pay_mode")]
        public string PayMode { get; set; }
    }
}
