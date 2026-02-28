using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandShopInfoBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandShopInfoBatchqueryModel : AopObject
    {
        /// <summary>
        /// 行政区划版本，当前可传空值(取默认版本)、2022Q2、UPTODATE(取最新版本)，其中空值默认为：2020Q1版本（ address_version=''或null），想要查看版本是2022年2季度版本则传入:(address_version='2022Q2')，想要获取最新版本则传入:(address_version ='UPTODATE')
        /// </summary>
        [XmlElement("address_version")]
        public string AddressVersion { get; set; }

        /// <summary>
        /// 团购门店业务类型来源，查询蚂蚁门店不必传，查询团购门店传：APLUS_SHOP
        /// </summary>
        [XmlElement("biz_source")]
        public string BizSource { get; set; }

        /// <summary>
        /// 商户角色id，表示将要开的店属于哪个商户角色。对于直连开店场景，填写商户pid；对于间连开店场景（线上、线下、直付通），填写商户smid
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// need_industry_info=0时不返回行业信息；need_industry_info=1时返回不需要审核的行业信息、审核通过的行业信息
        /// </summary>
        [XmlElement("need_industry_info")]
        public string NeedIndustryInfo { get; set; }

        /// <summary>
        /// need_industry_license=0时不返回行业资质；need_industry_license=1时返回审核通过的行业资质
        /// </summary>
        [XmlElement("need_industry_license")]
        public string NeedIndustryLicense { get; set; }

        /// <summary>
        /// 门店不置信时，是否需要返回shop_recommend_info
        /// </summary>
        [XmlElement("need_recommend")]
        public string NeedRecommend { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页记录数，最大值为100
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 门店类型。 查询蚂蚁门店不用传，团购门店需要传：GROUP_BUY
        /// </summary>
        [XmlElement("shop_type")]
        public string ShopType { get; set; }
    }
}
