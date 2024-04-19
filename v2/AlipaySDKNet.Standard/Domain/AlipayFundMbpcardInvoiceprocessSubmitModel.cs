using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundMbpcardInvoiceprocessSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundMbpcardInvoiceprocessSubmitModel : AopObject
    {
        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 发票详情信息列表
        /// </summary>
        [XmlArray("invoice_list")]
        [XmlArrayItem("invoice_base_info")]
        public List<InvoiceBaseInfo> InvoiceList { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 回票外部事件请求号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 关联的任务ID列表
        /// </summary>
        [XmlArray("task_id_list")]
        [XmlArrayItem("string")]
        public List<string> TaskIdList { get; set; }
    }
}
