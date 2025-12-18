using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundTransUniTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransUniTransferModel : AopObject
    {
        /// <summary>
        /// 描述特定的业务场景，可传的参数如下： DIRECT_TRANSFER：单笔无密转账到支付宝，B2C现金红包; PERSONAL_COLLECTION：C2C现金红包-领红包
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 转账业务请求的扩展参数，支持传入的扩展参数如下： sub_biz_scene 子业务场景，红包业务必传，C2C现金红包、B2C现金红包均需传入，取值REDPACKET
        /// </summary>
        [XmlElement("business_params")]
        public string BusinessParams { get; set; }

        /// <summary>
        /// 多币种信息字段，填充支付金额及币种，转账金额及币种，结算金额及币种
        /// </summary>
        [XmlElement("mutiple_currency_detail")]
        public MutipleCurrencyDetail MutipleCurrencyDetail { get; set; }

        /// <summary>
        /// 转账业务的标题，用于在支付宝用户的账单里显示
        /// </summary>
        [XmlElement("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 原支付宝业务单号。
        /// </summary>
        [XmlElement("original_order_id")]
        public string OriginalOrderId { get; set; }

        /// <summary>
        /// 商家侧唯一订单号，由商家自定义。对于不同转账请求，商家需保证该订单号在自身系统唯一。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 公用回传参数，如果请求时传递了该参数，则异步通知商户时会回传该参数。
        /// </summary>
        [XmlElement("passback_params")]
        public string PassbackParams { get; set; }

        /// <summary>
        /// 收款方信息
        /// </summary>
        [XmlElement("payee_info")]
        public Participant PayeeInfo { get; set; }

        /// <summary>
        /// 付款方信息
        /// </summary>
        [XmlElement("payer_info")]
        public Participant PayerInfo { get; set; }

        /// <summary>
        /// 业务产品码， 单笔无密转账到支付宝账户固定为: TRANS_ACCOUNT_NO_PWD； 收发现金红包固定为: STD_RED_PACKET；
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 业务备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// "签名信息。 说明：仅特殊场景使用，现金红包场景无需关注。"
        /// </summary>
        [XmlElement("sign_data")]
        public SignData SignData { get; set; }

        /// <summary>
        /// 订单总金额，单位为元，精确到小数点后两位，STD_RED_PACKET产品取值范围[0.01,100000000]； TRANS_ACCOUNT_NO_PWD产品取值范围[0.1,100000000]
        /// </summary>
        [XmlElement("trans_amount")]
        public string TransAmount { get; set; }

        /// <summary>
        /// 该笔转账使用的转账场景，商户可前往【<a href="https://b.alipay.com/page/bizfund/transferScene/list">支付宝商家平台-资金管理-转账场景</a>】中查看/申明转账场景。<br> 目前支持以下枚举值：现金营销、企业退款、佣金报酬、业务结算、二手回收、公益补助、行政补贴和退款、保险理赔
        /// </summary>
        [XmlElement("transfer_scene_name")]
        public string TransferSceneName { get; set; }

        /// <summary>
        /// 转账场景信息，包含转账场景信息类型和转账场景信息描述。需按该笔转账使用的转账场景准确填写
        /// </summary>
        [XmlArray("transfer_scene_report_infos")]
        [XmlArrayItem("transfer_scene_report_info")]
        public List<TransferSceneReportInfo> TransferSceneReportInfos { get; set; }
    }
}
