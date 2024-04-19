using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingVoucherBatchsendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingVoucherBatchsendModel : AopObject
    {
        /// <summary>
        /// 是否异步发放
        /// </summary>
        [XmlElement("async")]
        public bool Async { get; set; }

        /// <summary>
        /// 业务来源
        /// </summary>
        [XmlElement("biz_from")]
        public string BizFrom { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 支付宝用户ID(映射的openId)
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务号，用户幂等控制
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 券是否需要主动领取
        /// </summary>
        [XmlElement("to_claim")]
        public bool ToClaim { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 券列表
        /// </summary>
        [XmlArray("vouchers")]
        [XmlArrayItem("open_batch_voucher")]
        public List<OpenBatchVoucher> Vouchers { get; set; }
    }
}
