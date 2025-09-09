using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRecycleUserassetRecordBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceRecycleUserassetRecordBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 页数
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 流水总条数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 资产余额，单位：分
        /// </summary>
        [XmlElement("user_asset_amount")]
        public long UserAssetAmount { get; set; }

        /// <summary>
        /// 资产流水集合
        /// </summary>
        [XmlArray("user_asset_record_list")]
        [XmlArrayItem("recycle_user_asset_record_d_t_o")]
        public List<RecycleUserAssetRecordDTO> UserAssetRecordList { get; set; }

        /// <summary>
        /// 用户可提现金额，单位：分
        /// </summary>
        [XmlElement("user_withdraw_amount")]
        public long UserWithdrawAmount { get; set; }
    }
}
