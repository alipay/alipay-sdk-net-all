using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundAccountbookPageCreateResponse.
    /// </summary>
    public class AlipayFundAccountbookPageCreateResponse : AopResponse
    {
        /// <summary>
        /// 业务场景码，固定值：页面创建
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 外部单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 当前开通状态
        /// </summary>
        [XmlElement("process_status")]
        public string ProcessStatus { get; set; }

        /// <summary>
        /// 产品码，固定值：资金账本管理
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
