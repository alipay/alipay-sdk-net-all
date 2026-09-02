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
        /// 店铺LOGO 地址
        /// </summary>
        [XmlElement("a_store_logo")]
        public string AStoreLogo { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("a_store_name")]
        public string AStoreName { get; set; }

        /// <summary>
        /// 申请业务类型： INDIVIDUAL 独立门店 BRAND 品牌连锁门店 SINGLE_MALL  单体mall HEAD_MALL 总部mall
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

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
        /// 最新的直付通入驻订单审核结果
        /// </summary>
        [XmlElement("es_store_audit_result")]
        public EsStoreAuditOpenResult EsStoreAuditResult { get; set; }

        /// <summary>
        /// 联系手机号(示例值是示范,正常返回不需要掩码)
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 商户OID
        /// </summary>
        [XmlElement("oid")]
        public string Oid { get; set; }

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
