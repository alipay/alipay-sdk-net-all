using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardOpenCreateResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardOpenCreateResponse : AopResponse
    {
        /// <summary>
        /// 提交失败的原因
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 商户二级类目code
        /// </summary>
        [XmlElement("mcc_code")]
        public string MccCode { get; set; }

        /// <summary>
        /// 商户二级类目名称
        /// </summary>
        [XmlElement("mcc_name")]
        public string MccName { get; set; }

        /// <summary>
        /// 开通是否成功
        /// </summary>
        [XmlElement("submit_result")]
        public bool SubmitResult { get; set; }
    }
}
