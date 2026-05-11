using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AcquirePayFlowShopInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AcquirePayFlowShopInfo : AopObject
    {
        /// <summary>
        /// 客户详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 最新结算卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 商户所在市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 交易详情列表
        /// </summary>
        [XmlArray("detail_list")]
        [XmlArrayItem("acquire_pay_flow_trans_detail_info")]
        public List<AcquirePayFlowTransDetailInfo> DetailList { get; set; }

        /// <summary>
        /// 商户所在区
        /// </summary>
        [XmlElement("district")]
        public string District { get; set; }

        /// <summary>
        /// 第一次交易日期
        /// </summary>
        [XmlElement("first_date")]
        public string FirstDate { get; set; }

        /// <summary>
        /// 一级行业
        /// </summary>
        [XmlElement("industry_level_1")]
        public string IndustryLevel1 { get; set; }

        /// <summary>
        /// 二级行业
        /// </summary>
        [XmlElement("industry_level_2")]
        public string IndustryLevel2 { get; set; }

        /// <summary>
        /// 是否企业店铺
        /// </summary>
        [XmlElement("is_ent_shop")]
        public string IsEntShop { get; set; }

        /// <summary>
        /// 最近一次交易日期
        /// </summary>
        [XmlElement("last_date")]
        public string LastDate { get; set; }

        /// <summary>
        /// 店铺是否有防套现/刷单/虚假交易机制
        /// </summary>
        [XmlElement("prevent_spam_flag")]
        public string PreventSpamFlag { get; set; }

        /// <summary>
        /// 商户所在省
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 注册号
        /// </summary>
        [XmlElement("reg_no")]
        public string RegNo { get; set; }

        /// <summary>
        /// 店铺id（店铺在支付机构生成的唯一ID）
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 商户最早签约日期
        /// </summary>
        [XmlElement("sign_date")]
        public string SignDate { get; set; }

        /// <summary>
        /// 统一信用代码
        /// </summary>
        [XmlElement("uscc")]
        public string Uscc { get; set; }
    }
}
