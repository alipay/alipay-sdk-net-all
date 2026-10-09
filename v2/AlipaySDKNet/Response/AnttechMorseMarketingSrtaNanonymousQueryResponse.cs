using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechMorseMarketingSrtaNanonymousQueryResponse.
    /// </summary>
    public class AnttechMorseMarketingSrtaNanonymousQueryResponse : AopResponse
    {
        /// <summary>
        /// 蚂蚁侧返回的唯一标识
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 手机号二次加密密文值，对一次加密密文进行二次签署
        /// </summary>
        [XmlElement("blind_signed_mobile_sha_256")]
        public string BlindSignedMobileSha256 { get; set; }

        /// <summary>
        /// 匿名返回的加密数据。通过匿名解密后，数据格式为{"min_amount":"1.00","channel":"xx银行信用卡","max_amount":"5.00","need_deduct":"true","prize_type":"reduce"}
        /// </summary>
        [XmlElement("result_cipher_list")]
        public string ResultCipherList { get; set; }
    }
}
