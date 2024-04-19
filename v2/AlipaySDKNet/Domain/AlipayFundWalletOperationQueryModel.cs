using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundWalletOperationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundWalletOperationQueryModel : AopObject
    {
        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlArray("biz_types")]
        [XmlArrayItem("string")]
        public List<string> BizTypes { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        [XmlElement("current_page")]
        public string CurrentPage { get; set; }

        /// <summary>
        /// 业务结束时间
        /// </summary>
        [XmlElement("end_biz_dt")]
        public string EndBizDt { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 业务起始时间
        /// </summary>
        [XmlElement("start_biz_dt")]
        public string StartBizDt { get; set; }

        /// <summary>
        /// 用户钱包id
        /// </summary>
        [XmlElement("user_wallet_id")]
        public string UserWalletId { get; set; }
    }
}
