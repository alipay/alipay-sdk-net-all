using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PayFlowShopInfoModel Data Structure.
    /// </summary>
    [Serializable]
    public class PayFlowShopInfoModel : AopObject
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
        [XmlArrayItem("pay_flow_trans_detail_info_model")]
        public List<PayFlowTransDetailInfoModel> DetailList { get; set; }

        /// <summary>
        /// 商户所在区
        /// </summary>
        [XmlElement("district")]
        public string District { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("extend")]
        public string Extend { get; set; }

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
        /// 三级行业
        /// </summary>
        [XmlElement("industry_level_3")]
        public string IndustryLevel3 { get; set; }

        /// <summary>
        /// 四级行业
        /// </summary>
        [XmlElement("industry_level_4")]
        public string IndustryLevel4 { get; set; }

        /// <summary>
        /// 最近一次交易日期
        /// </summary>
        [XmlElement("last_date")]
        public string LastDate { get; set; }

        /// <summary>
        /// 近12个月交易笔数波动系数
        /// </summary>
        [XmlElement("ord_acnt_acv_12_m_suc")]
        public string OrdAcntAcv12MSuc { get; set; }

        /// <summary>
        /// 近1个月交易笔数波动系数
        /// </summary>
        [XmlElement("ord_acnt_acv_1_m_suc")]
        public string OrdAcntAcv1MSuc { get; set; }

        /// <summary>
        /// 近3个月交易笔数波动系数
        /// </summary>
        [XmlElement("ord_acnt_acv_3_m_suc")]
        public string OrdAcntAcv3MSuc { get; set; }

        /// <summary>
        /// 近6个月交易笔数波动系数
        /// </summary>
        [XmlElement("ord_acnt_acv_6_m_suc")]
        public string OrdAcntAcv6MSuc { get; set; }

        /// <summary>
        /// 近12个月交易笔数平稳系数
        /// </summary>
        [XmlElement("ord_acnt_adf_12_m_suc")]
        public string OrdAcntAdf12MSuc { get; set; }

        /// <summary>
        /// 近1个月交易笔数平稳系数
        /// </summary>
        [XmlElement("ord_acnt_adf_1_m_suc")]
        public string OrdAcntAdf1MSuc { get; set; }

        /// <summary>
        /// 近3个月交易笔数平稳系数
        /// </summary>
        [XmlElement("ord_acnt_adf_3_m_suc")]
        public string OrdAcntAdf3MSuc { get; set; }

        /// <summary>
        /// 近6个月交易笔数平稳系数
        /// </summary>
        [XmlElement("ord_acnt_adf_6_m_suc")]
        public string OrdAcntAdf6MSuc { get; set; }

        /// <summary>
        /// 近12个月交易金额波动系数
        /// </summary>
        [XmlElement("ord_amt_acv_12_m_suc")]
        public string OrdAmtAcv12MSuc { get; set; }

        /// <summary>
        /// 近1个月交易金额波动系数
        /// </summary>
        [XmlElement("ord_amt_acv_1_m_suc")]
        public string OrdAmtAcv1MSuc { get; set; }

        /// <summary>
        /// 近3个月交易金额波动系数
        /// </summary>
        [XmlElement("ord_amt_acv_3_m_suc")]
        public string OrdAmtAcv3MSuc { get; set; }

        /// <summary>
        /// 近6个月交易金额波动系数
        /// </summary>
        [XmlElement("ord_amt_acv_6_m_suc")]
        public string OrdAmtAcv6MSuc { get; set; }

        /// <summary>
        /// 近12个月交易金额平稳系数
        /// </summary>
        [XmlElement("ord_amt_adf_12_m_suc")]
        public string OrdAmtAdf12MSuc { get; set; }

        /// <summary>
        /// 近1个月交易金额平稳系数
        /// </summary>
        [XmlElement("ord_amt_adf_1_m_suc")]
        public string OrdAmtAdf1MSuc { get; set; }

        /// <summary>
        /// 近3个月交易金额平稳系数
        /// </summary>
        [XmlElement("ord_amt_adf_3_m_suc")]
        public string OrdAmtAdf3MSuc { get; set; }

        /// <summary>
        /// 近6个月交易金额平稳系数
        /// </summary>
        [XmlElement("ord_amt_adf_6_m_suc")]
        public string OrdAmtAdf6MSuc { get; set; }

        /// <summary>
        /// 平台名称
        /// </summary>
        [XmlElement("platform_name")]
        public string PlatformName { get; set; }

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
