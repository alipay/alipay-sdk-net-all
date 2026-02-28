using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherSubsidyModel Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherSubsidyModel : AopObject
    {
        /// <summary>
        /// 该张券适用的银行机构，供信用卡分期组装参数时使用
        /// </summary>
        [XmlArray("applicable_inst_id_list")]
        [XmlArrayItem("string")]
        public List<string> ApplicableInstIdList { get; set; }

        /// <summary>
        /// 剩余可使用次数
        /// </summary>
        [XmlElement("available_count")]
        public string AvailableCount { get; set; }

        /// <summary>
        /// 折后对客费率，小数形式
        /// </summary>
        [XmlElement("discount_buyer_rate")]
        public long DiscountBuyerRate { get; set; }

        /// <summary>
        /// 失效日期
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 类免息卡折扣比例
        /// </summary>
        [XmlElement("fee_discount_ratio")]
        public long FeeDiscountRatio { get; set; }

        /// <summary>
        /// 支持的分期产品场景列表
        /// </summary>
        [XmlArray("fq_product_scene_list")]
        [XmlArrayItem("string")]
        public List<string> FqProductSceneList { get; set; }

        /// <summary>
        /// 是否积分类型
        /// </summary>
        [XmlElement("fq_subsidy_point_operation")]
        public bool FqSubsidyPointOperation { get; set; }

        /// <summary>
        /// 是否国补折扣券
        /// </summary>
        [XmlElement("government_subsidy_plat_from_discount")]
        public bool GovernmentSubsidyPlatFromDiscount { get; set; }

        /// <summary>
        /// 信用卡分期-折扣券对应机构价格方案key
        /// </summary>
        [XmlElement("inst_price_code")]
        public string InstPriceCode { get; set; }

        /// <summary>
        /// 分期期数
        /// </summary>
        [XmlElement("install_num")]
        public string InstallNum { get; set; }

        /// <summary>
        /// 最小核销数
        /// </summary>
        [XmlElement("min_write_off_num")]
        public long MinWriteOffNum { get; set; }

        /// <summary>
        /// 是否在收银台展示无限次描述(折扣券配置选择是的时候才是true，其他场景都是false，具体是否展示由使用方控制)
        /// </summary>
        [XmlElement("show_desc_cashier")]
        public bool ShowDescCashier { get; set; }

        /// <summary>
        /// 使用场景
        /// </summary>
        [XmlElement("used_scenes")]
        public string UsedScenes { get; set; }

        /// <summary>
        /// 类免息卡ID
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }

        /// <summary>
        /// 类免息卡名称
        /// </summary>
        [XmlElement("voucher_name")]
        public string VoucherName { get; set; }

        /// <summary>
        /// 类免息卡产品码
        /// </summary>
        [XmlElement("voucher_product_code")]
        public string VoucherProductCode { get; set; }
    }
}
