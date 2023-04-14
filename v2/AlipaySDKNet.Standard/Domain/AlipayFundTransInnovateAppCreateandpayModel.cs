using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundTransInnovateAppCreateandpayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransInnovateAppCreateandpayModel : AopObject
    {
        /// <summary>
        /// 描述特定的业务场景，如果传递了out_biz_no则该字段为必传。 房租：HOUSE_RENT
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 转账业务请求的扩展参数，格式为json格式 支持如下属性： sub_biz_scene 子场景
        /// </summary>
        [XmlElement("business_params")]
        public string BusinessParams { get; set; }

        /// <summary>
        /// 房租的标题，用于在支付宝用户的账单里显示。如果不传会根据不同的场景和pid进行固定文案替换
        /// </summary>
        [XmlElement("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 商户转账唯一订单号，发起转账来源方定义的转账单据ID。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 收款方信息
        /// </summary>
        [XmlElement("payee_info")]
        public Participant PayeeInfo { get; set; }

        /// <summary>
        /// 付款指定支付渠道类型
        /// </summary>
        [XmlArray("payer_enable_channels_info_list")]
        [XmlArrayItem("payer_payment_d_t_o")]
        public List<PayerPaymentDTO> PayerEnableChannelsInfoList { get; set; }

        /// <summary>
        /// 付款用户账号信息，房租场景是必填
        /// </summary>
        [XmlElement("payer_info")]
        public Participant PayerInfo { get; set; }

        /// <summary>
        /// 销售产品码，商家和支付宝签约的产品码，如果传递了out_biz_no则该字段为必传。可传值如下： 转账到支付宝账号 TRANSFER_TO_ALIPAY_ACCOUNT 转账到银行卡 TRANSFER_TO_BANK_CARD
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 业务备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 绝对超时时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("time_expire")]
        public string TimeExpire { get; set; }

        /// <summary>
        /// 订单总金额，单位为元，精确到小数点后两位： TRANSFER_TO_ALIPAY_ACCOUNT 产品取值范围[0.1,100000000]
        /// </summary>
        [XmlElement("trans_amount")]
        public string TransAmount { get; set; }
    }
}
