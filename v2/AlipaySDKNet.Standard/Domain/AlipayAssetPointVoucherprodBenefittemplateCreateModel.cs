using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAssetPointVoucherprodBenefittemplateCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAssetPointVoucherprodBenefittemplateCreateModel : AopObject
    {
        /// <summary>
        /// 资产类型，要创建的资产的类型，BENEFIT_TEMPLATE表示权益模板，由支付宝权益结算平台定义
        /// </summary>
        [XmlElement("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// 自动拉起收银台，true表示自动拉起收银台，默认为false
        /// </summary>
        [XmlElement("auto_recharge")]
        public bool AutoRecharge { get; set; }

        /// <summary>
        /// 业务时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("biz_dt")]
        public string BizDt { get; set; }

        /// <summary>
        /// 业务来源，使用业务系统的名称
        /// </summary>
        [XmlElement("biz_from")]
        public string BizFrom { get; set; }

        /// <summary>
        /// 业务号，用于保证幂等，业务系统保证其唯一性
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 权益模板所对应的业务方活动id
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 创建模板的资金信息，包括出资账号，账号类型，金额，结算类型和结算截止时间，金额必填，数组中只用填充一个
        /// </summary>
        [XmlArray("fund_infos")]
        [XmlArrayItem("asset_fund_info")]
        public List<AssetFundInfo> FundInfos { get; set; }

        /// <summary>
        /// 权益名称，权益模板的名称标识，业务系统与权益结算平台共同约定
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 支付宝会员ID，需要创建权益模板的商户的支付宝会员id
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 权益产品码，不同场景下会有不同的产品码，由支付宝权益结算平台指定，GAODE_SHADOW表示高德权益结算场景下的产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 权益模板过期时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("publish_end_time")]
        public string PublishEndTime { get; set; }

        /// <summary>
        /// 权益实体有效期，此对象不能为空，对象内部的内部过期时间可以为空（表示相对时间为0m）
        /// </summary>
        [XmlElement("valid_period")]
        public AssetValidPeriod ValidPeriod { get; set; }
    }
}
