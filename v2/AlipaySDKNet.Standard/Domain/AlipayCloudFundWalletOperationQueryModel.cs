using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudFundWalletOperationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudFundWalletOperationQueryModel : AopObject
    {
        /// <summary>
        /// 业务类型 【枚举值】 核销: PAYMENT 核销退: REFUND 充值: DEPOSIT 提现: WITHDRAW 充退: RETURN
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
        /// 业务开始时间
        /// </summary>
        [XmlElement("start_biz_dt")]
        public string StartBizDt { get; set; }

        /// <summary>
        /// 钱包id
        /// </summary>
        [XmlElement("user_wallet_id")]
        public string UserWalletId { get; set; }
    }
}
