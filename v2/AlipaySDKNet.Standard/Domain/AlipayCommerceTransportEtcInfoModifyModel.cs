using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEtcInfoModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEtcInfoModifyModel : AopObject
    {
        /// <summary>
        /// 支付宝侧业务协议号，在订单同步接口中会同步给外部机构。与biz_agreement_no参数，两者二选一必传。
        /// </summary>
        [XmlElement("biz_agreement_no")]
        public string BizAgreementNo { get; set; }

        /// <summary>
        /// 用户ETC卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 用户ETC OBU号
        /// </summary>
        [XmlElement("device_no")]
        public string DeviceNo { get; set; }

        /// <summary>
        /// 蚂蚁会员统一ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝侧申请订单号，在订单同步接口中会同步给外部机构。与biz_agreement_no参数，两者二选一必传。
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部业务号，在支付宝订单同步给外部机构时，由外部生成并返回给支付宝，对应用户该笔ETC申请单号。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 0：蓝； 1：黄； 2：黑； 3：白； 4：渐变绿
        /// </summary>
        [XmlElement("plate_color")]
        public string PlateColor { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("plate_no")]
        public string PlateNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 核定人数
        /// </summary>
        [XmlElement("vi_ac")]
        public string ViAc { get; set; }

        /// <summary>
        /// 总质量,单位kg
        /// </summary>
        [XmlElement("vi_gross_mass")]
        public string ViGrossMass { get; set; }

        /// <summary>
        /// 车高，单位mm
        /// </summary>
        [XmlElement("vi_height")]
        public string ViHeight { get; set; }

        /// <summary>
        /// 车长，单位mm
        /// </summary>
        [XmlElement("vi_length")]
        public string ViLength { get; set; }

        /// <summary>
        /// 行驶证上的车主姓名
        /// </summary>
        [XmlElement("vi_owner_name")]
        public string ViOwnerName { get; set; }

        /// <summary>
        /// 车宽，单位mm
        /// </summary>
        [XmlElement("vi_width")]
        public string ViWidth { get; set; }
    }
}
