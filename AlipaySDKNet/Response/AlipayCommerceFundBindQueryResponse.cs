using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceFundBindQueryResponse.
    /// </summary>
    public class AlipayCommerceFundBindQueryResponse : AopResponse
    {
        /// <summary>
        /// 银行卡信息，用户授权银行卡信息后返回
        /// </summary>
        [XmlElement("bank_card_info")]
        public FundBankCardInfoDTO BankCardInfo { get; set; }

        /// <summary>
        /// 用户绑卡失败时，该字段会返回错误code，需结合code_msg一起排查问题。
        /// </summary>
        [XmlElement("bind_error_code")]
        public string BindErrorCode { get; set; }

        /// <summary>
        /// 用户绑卡失败时，具体的错误描述会通过该字段返回。错误解决办法请参考接入文档。
        /// </summary>
        [XmlElement("bind_error_msg")]
        public string BindErrorMsg { get; set; }

        /// <summary>
        /// 用户证件号，和cert_type联合使用
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 绑卡用户的证件类型。0:身份证 1:护照 2:军官证 3:士兵证 4:回乡证 5:临时身份证 6:户口簿 7:警官证 8:台胞证 9:营业执照10:其它证件 11:港澳居民来往内地通行证 12:台湾居民来往大陆通行证 13:台湾居民居住证 14:港澳居民居住证 15:港澳身份证 16:外国人永久居住证
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 商户维度下唯一标识一个用户信息，用户授权后才会返回。
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部绑卡流水号，用来标识一次绑卡行为，商户维度下需确保唯一，绑卡接口时传入。
        /// </summary>
        [XmlElement("out_bind_no")]
        public string OutBindNo { get; set; }

        /// <summary>
        /// 绑卡用户的真实姓名
        /// </summary>
        [XmlElement("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 用户绑卡状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID。用户完成用户信息授权之后，该字段才会返回
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 代扣签约信息，绑卡成功后才会返回该字段。
        /// </summary>
        [XmlElement("withhold_agreement_info")]
        public WithholdAgreementInfoDTO WithholdAgreementInfo { get; set; }
    }
}
