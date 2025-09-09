using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustrySalaryPaymentApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustrySalaryPaymentApplyModel : AopObject
    {
        /// <summary>
        /// 大于0，金额为分
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 默认填写156(人民币)
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 代发商户商户号
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 外部流水号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 01：余额支付
        /// </summary>
        [XmlElement("pay_way")]
        public string PayWay { get; set; }

        /// <summary>
        /// 收款人账户类型
        /// </summary>
        [XmlElement("payee_account_type")]
        public string PayeeAccountType { get; set; }

        /// <summary>
        /// 收款人支行名称
        /// </summary>
        [XmlElement("payee_branch_name")]
        public string PayeeBranchName { get; set; }

        /// <summary>
        /// 收款人卡号
        /// </summary>
        [XmlElement("payee_card_no")]
        public string PayeeCardNo { get; set; }

        /// <summary>
        /// 对私、对公代发都可不传 若传收方身份证，则在对私代发至网商、支付宝账户时校验证件有效性，其余场景均不校验
        /// </summary>
        [XmlElement("payee_cert_no")]
        public string PayeeCertNo { get; set; }

        /// <summary>
        /// 对公银行卡必填
        /// </summary>
        [XmlElement("payee_contact_line")]
        public string PayeeContactLine { get; set; }

        /// <summary>
        /// 收款人手机号码
        /// </summary>
        [XmlElement("payee_mobile")]
        public string PayeeMobile { get; set; }

        /// <summary>
        /// 收款人姓名
        /// </summary>
        [XmlElement("payee_name")]
        public string PayeeName { get; set; }

        /// <summary>
        /// 出资的子户账号
        /// </summary>
        [XmlElement("payer_card_no")]
        public string PayerCardNo { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 备注字段枚举值：代发工资、奖金、绩效、津贴、补贴、对公支付
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 业务场景标识采用key1=value1|key2=value2|key3=value3格式
        /// </summary>
        [XmlElement("scene_tag")]
        public string SceneTag { get; set; }

        /// <summary>
        /// 对接收付通加签的xml，通过base64Encode编码
        /// </summary>
        [XmlElement("sign_xml")]
        public string SignXml { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
