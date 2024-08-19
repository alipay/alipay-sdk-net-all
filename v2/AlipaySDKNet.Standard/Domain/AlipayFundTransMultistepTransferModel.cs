using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundTransMultistepTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransMultistepTransferModel : AopObject
    {
        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 多步转账明细
        /// </summary>
        [XmlArray("order_details")]
        [XmlArrayItem("multi_step_trans_order_detail_request")]
        public List<MultiStepTransOrderDetailRequest> OrderDetails { get; set; }

        /// <summary>
        /// 保证外部单号的唯一幂等
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 公用回传参数，如果请求时传递了该参数，则异步通知商户时会回传该参数。
        /// </summary>
        [XmlElement("passback_params")]
        public string PassbackParams { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 用于备注单据一些使用功能或是额外的一些标记
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 转账的金额 (单位：元)
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 总数量，单位是条
        /// </summary>
        [XmlElement("total_count")]
        public string TotalCount { get; set; }
    }
}
