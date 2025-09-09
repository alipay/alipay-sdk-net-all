using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRecycleMerchantassetRecordBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceRecycleMerchantassetRecordBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 资金账号
        /// </summary>
        [XmlElement("fund_account")]
        public string FundAccount { get; set; }

        /// <summary>
        /// 资产余额，单位：分
        /// </summary>
        [XmlElement("merchant_asset_amount")]
        public long MerchantAssetAmount { get; set; }

        /// <summary>
        /// 商户资产流水集合
        /// </summary>
        [XmlArray("merchant_asset_record_list")]
        [XmlArrayItem("recycle_merchant_asset_record_d_t_o")]
        public List<RecycleMerchantAssetRecordDTO> MerchantAssetRecordList { get; set; }

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
        /// sellerid集合
        /// </summary>
        [XmlArray("seller_id_list")]
        [XmlArrayItem("string")]
        public List<string> SellerIdList { get; set; }

        /// <summary>
        /// 商户补贴比例
        /// </summary>
        [XmlElement("subsidy_ratio")]
        public string SubsidyRatio { get; set; }

        /// <summary>
        /// 流水总条数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
