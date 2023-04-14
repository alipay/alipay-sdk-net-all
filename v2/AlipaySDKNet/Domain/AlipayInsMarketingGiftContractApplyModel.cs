using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsMarketingGiftContractApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsMarketingGiftContractApplyModel : AopObject
    {
        /// <summary>
        /// 租客等信息
        /// </summary>
        [XmlElement("biz_data_for_bx_policy")]
        public string BizDataForBxPolicy { get; set; }

        /// <summary>
        /// 赠险渠道，包含渠道规则等
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 合约值，外部透传，原样返回
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// entrance 运营配置入口
        /// </summary>
        [XmlElement("entrance")]
        public string Entrance { get; set; }

        /// <summary>
        /// 赠险产品标志
        /// </summary>
        [XmlElement("gift_prod_code")]
        public string GiftProdCode { get; set; }

        /// <summary>
        /// 投保参数
        /// </summary>
        [XmlElement("ins_apply_product_coverage_dto")]
        public InsApplyProductCoverageDTO InsApplyProductCoverageDto { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 和申请人关系，默认1
        /// </summary>
        [XmlElement("relation_to_apply")]
        public string RelationToApply { get; set; }

        /// <summary>
        /// 和投保人关系，5，其他
        /// </summary>
        [XmlElement("relation_to_holder")]
        public string RelationToHolder { get; set; }

        /// <summary>
        /// 赠险产品码
        /// </summary>
        [XmlElement("right_no")]
        public string RightNo { get; set; }

        /// <summary>
        /// 运营识别来源渠道
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
