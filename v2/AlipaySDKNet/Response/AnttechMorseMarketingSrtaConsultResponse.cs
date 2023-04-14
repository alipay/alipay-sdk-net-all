using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechMorseMarketingSrtaConsultResponse.
    /// </summary>
    public class AnttechMorseMarketingSrtaConsultResponse : AopResponse
    {
        /// <summary>
        /// 蚂蚁侧返回的唯一标识，用问题定位
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 二次加密的密文值，是对一次加密密文进行二次签署
        /// </summary>
        [XmlElement("blind_signed_mobile_sha_256")]
        public string BlindSignedMobileSha256 { get; set; }

        /// <summary>
        /// 匿名返回的加密数据。通过匿名解密后，数据格式为[     {       "campaign_channel": "xx银行信用卡",       "campaign_channel_code": "xxB_CC",       "campaign_id": "62e01b2f3b2f43f1bff84354f7ec0a29001",       "idea_content": "xx银行信用卡0.2减0.01",       "idea_type": "binding",       "max_amount": "0.01",       "min_amount": "0.01",       "threshold": "0.2"     }   ]
        /// </summary>
        [XmlElement("result_cipher_list")]
        public string ResultCipherList { get; set; }
    }
}
