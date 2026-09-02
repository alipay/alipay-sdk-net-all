using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotDapplyOrderdetailQueryResponse.
    /// </summary>
    public class AlipayCommerceIotDapplyOrderdetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 下单时传入的收货详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 下单时传入的申请人手机号脱敏信息
        /// </summary>
        [XmlElement("applicant_mobile")]
        public string ApplicantMobile { get; set; }

        /// <summary>
        /// 申请人脱敏信息
        /// </summary>
        [XmlElement("applicant_name")]
        public string ApplicantName { get; set; }

        /// <summary>
        /// 供应链系统订单号，又称AO单，当审核通过提交供应链后生成相应单号
        /// </summary>
        [XmlElement("asset_apply_order_id")]
        public string AssetApplyOrderId { get; set; }

        /// <summary>
        /// 批次下单生成的批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 下单时传入的城市对应的城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 下单时传入的城市
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 下单时传入的区对应的编码
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 下单时传入的区
        /// </summary>
        [XmlElement("district_name")]
        public string DistrictName { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 下单时传入的备注信息
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 设备申请业务订单号（唯一键）
        /// </summary>
        [XmlElement("order_biz_id")]
        public string OrderBizId { get; set; }

        /// <summary>
        /// 设备申请单状态枚举值
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 省编码
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 下单时传入的收货人信息
        /// </summary>
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 下单时传入的收货人手机号
        /// </summary>
        [XmlElement("receiver_mobile")]
        public string ReceiverMobile { get; set; }

        /// <summary>
        /// 批次下单时传入的收货人姓名脱敏信息
        /// </summary>
        [XmlElement("receiver_name")]
        public string ReceiverName { get; set; }

        /// <summary>
        /// 下单时用户传入的门店名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 订单状态对应的中文描述
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
