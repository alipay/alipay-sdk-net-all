using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankEcnyTradeQrcodecreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankEcnyTradeQrcodecreateModel : AopObject
    {
        /// <summary>
        /// 未设置为不带金额的收款码，设置为带金额的收款码
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 附加信息，受理机构在发码时传入，收款运营机构在交易确认的时候会回传
        /// </summary>
        [XmlElement("attach_params")]
        public string AttachParams { get; set; }

        /// <summary>
        /// 业务扩展参数,json格式
        /// </summary>
        [XmlElement("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 不填为默认值收款码(collect_code)
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
