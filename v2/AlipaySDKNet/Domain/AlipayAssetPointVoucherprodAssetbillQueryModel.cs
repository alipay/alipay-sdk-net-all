using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAssetPointVoucherprodAssetbillQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAssetPointVoucherprodAssetbillQueryModel : AopObject
    {
        /// <summary>
        /// 资产id，要查询流水的模版id
        /// </summary>
        [XmlElement("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 资产类型，要创建的资产的类型，BENEFIT_TEMPLATE表示权益模板，由支付宝权益结算平台定义
        /// </summary>
        [XmlElement("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// 业务号，需要查询的流水所对应的上游业务系统流水号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 业务类型： BENEFIT_TEMPLATE_RECHARGE: 创建模版 BENEFIT_TEMPLATE_RECYCLE: 模版回收 BENEFIT_TEMPLATE_SETTLE: 结算 BENEFIT_TEMPLATE_APPEND: 追加
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 要查询的流水的最晚业务时间
        /// </summary>
        [XmlElement("end_biz_dt")]
        public string EndBizDt { get; set; }

        /// <summary>
        /// 流水页码，不传时默认为1
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 流水分页大小，不传时默认10
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 开始时间，要查询的流水的最早业务时间
        /// </summary>
        [XmlElement("start_biz_dt")]
        public string StartBizDt { get; set; }

        /// <summary>
        /// 支付宝会员id，资产所属用户的支付宝会员id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
