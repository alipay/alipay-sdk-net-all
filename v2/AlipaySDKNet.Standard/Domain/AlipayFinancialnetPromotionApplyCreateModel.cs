using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFinancialnetPromotionApplyCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinancialnetPromotionApplyCreateModel : AopObject
    {
        /// <summary>
        /// 申请人支付宝UID
        /// </summary>
        [XmlElement("apply_open_id")]
        public string ApplyOpenId { get; set; }

        /// <summary>
        /// 额度申请需要传入： 1. 进件模版信息 2. 业务订单扩展字段extParam，json格式,  firstpayamt,lastpayamt,monthpayamt下单要求必传，值大于等于0
        /// </summary>
        [XmlElement("apply_template_info")]
        public string ApplyTemplateInfo { get; set; }

        /// <summary>
        /// 申请人支付宝UID
        /// </summary>
        [XmlElement("apply_user_id")]
        public string ApplyUserId { get; set; }

        /// <summary>
        /// 车商合作伙伴id，蚂蚁机构信息中心分配
        /// </summary>
        [XmlElement("asset_inst_id")]
        public string AssetInstId { get; set; }

        /// <summary>
        /// 门店id，蚂蚁机构信息中心入驻分配
        /// </summary>
        [XmlElement("asset_resource_id")]
        public string AssetResourceId { get; set; }

        /// <summary>
        /// 合作平台系统ID（蚂蚁分配）
        /// </summary>
        [XmlElement("entry_app_id")]
        public string EntryAppId { get; set; }

        /// <summary>
        /// 网商分配资方路由码
        /// </summary>
        [XmlElement("finance_inst_iprole_id")]
        public string FinanceInstIproleId { get; set; }

        /// <summary>
        /// 资方合作伙伴id，蚂蚁机构信息中心分配
        /// </summary>
        [XmlElement("fund_inst_id")]
        public string FundInstId { get; set; }

        /// <summary>
        /// 机构编码，机构接入网商场景金融平台时分配，固定值
        /// </summary>
        [XmlElement("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 机构产品码，机构接入网商场景金融平台时分配，固定值
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 推广人支付宝UID
        /// </summary>
        [XmlElement("promote_open_id")]
        public string PromoteOpenId { get; set; }

        /// <summary>
        /// 推广人支付宝UID
        /// </summary>
        [XmlElement("promote_user_id")]
        public string PromoteUserId { get; set; }

        /// <summary>
        /// 签约参数
        /// </summary>
        [XmlElement("sign_info")]
        public SignInfo SignInfo { get; set; }
    }
}
