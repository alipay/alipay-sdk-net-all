using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpRegionalfinanceCreditchangesyncNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpRegionalfinanceCreditchangesyncNotifyModel : AopObject
    {
        /// <summary>
        /// 金融产品code码，接口提供方分配。不同的机构的金融产品code码不同
        /// </summary>
        [XmlElement("financial_product_code")]
        public string FinancialProductCode { get; set; }

        /// <summary>
        /// 商户自身的请求id，需保证其唯一性
        /// </summary>
        [XmlElement("merchant_request_id")]
        public string MerchantRequestId { get; set; }

        /// <summary>
        /// 授信变动通知具体内容，json字符串 json字段描示例如下： {"requestNo": "业务请求流水号", "creditApplyNo": "企信授信单号", "channelSeqNo": "行方授信单号(选填)", "channelUserId": "行方用户id", "approvelResult": "授信结果(0-不通过,1-通过)", "rejectCode": "拒绝原因编码(选填)", "rejectReason": "拒绝原因描述(选填)", "creditAmount": "授信额度,两位小数(选填)", "creditAmountValidity": "额度有效期,yyyy-MM-dd(选填)", "creditDrawValidity": "额度支用有效期,yyyy-MM-dd(选填)"}
        /// </summary>
        [XmlElement("notify_content")]
        public string NotifyContent { get; set; }
    }
}
