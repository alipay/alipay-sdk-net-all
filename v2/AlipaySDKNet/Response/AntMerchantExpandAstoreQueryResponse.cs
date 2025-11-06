using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandAstoreQueryResponse.
    /// </summary>
    public class AntMerchantExpandAstoreQueryResponse : AopResponse
    {
        /// <summary>
        /// 店铺id
        /// </summary>
        [XmlElement("a_store_id")]
        public string AStoreId { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("a_store_name")]
        public string AStoreName { get; set; }

        /// <summary>
        /// 品牌信息
        /// </summary>
        [XmlElement("brand_info")]
        public BrandInfoModel BrandInfo { get; set; }

        /// <summary>
        /// 商家经营类目
        /// </summary>
        [XmlElement("category_info")]
        public CategoryInfoModel CategoryInfo { get; set; }

        /// <summary>
        /// 外部业务编号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 结算信息模型
        /// </summary>
        [XmlElement("settle_infos")]
        public SettleInfoModel SettleInfos { get; set; }

        /// <summary>
        /// 二级商户id
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
