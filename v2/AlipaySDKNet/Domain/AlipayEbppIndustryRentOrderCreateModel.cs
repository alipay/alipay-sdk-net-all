using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryRentOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryRentOrderCreateModel : AopObject
    {
        /// <summary>
        /// 中心编号
        /// </summary>
        [XmlElement("accfund_center_no")]
        public string AccfundCenterNo { get; set; }

        /// <summary>
        /// 租房账单明细详情
        /// </summary>
        [XmlElement("bill_detail")]
        public RentPayBillDetail BillDetail { get; set; }

        /// <summary>
        /// 租房平台调用预创单接口后在该时间后业务超时(单位分钟)
        /// </summary>
        [XmlElement("biz_time_out")]
        public long BizTimeOut { get; set; }

        /// <summary>
        /// 身份证件号码md5加密后的字符串
        /// </summary>
        [XmlElement("cert_num")]
        public string CertNum { get; set; }

        /// <summary>
        /// 租房平台简称
        /// </summary>
        [XmlElement("housing_name")]
        public string HousingName { get; set; }

        /// <summary>
        /// 租房平台订单房源地址
        /// </summary>
        [XmlElement("housing_url")]
        public string HousingUrl { get; set; }

        /// <summary>
        /// 公积金机构所属城市编码
        /// </summary>
        [XmlElement("org_city")]
        public string OrgCity { get; set; }

        /// <summary>
        /// 公积金中心机构编码
        /// </summary>
        [XmlElement("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付完成后的跳转回租房平台的地址
        /// </summary>
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// 租房直付银行信息
        /// </summary>
        [XmlElement("rent_bank_info")]
        public RentPayBankInfo RentBankInfo { get; set; }

        /// <summary>
        /// 用户租房合同信息
        /// </summary>
        [XmlElement("rent_contract_info")]
        public RentPayContractInfo RentContractInfo { get; set; }
    }
}
