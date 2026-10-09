using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEtcenterpriseActivedorderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEtcenterpriseActivedorderCreateModel : AopObject
    {
        /// <summary>
        /// 经办人证件号
        /// </summary>
        [XmlElement("agent_cert_no")]
        public string AgentCertNo { get; set; }

        /// <summary>
        /// 经办人证件类型
        /// </summary>
        [XmlElement("agent_cert_type")]
        public string AgentCertType { get; set; }

        /// <summary>
        /// 经办人姓名
        /// </summary>
        [XmlElement("agent_name")]
        public string AgentName { get; set; }

        /// <summary>
        /// 业务发生时间，对应order_status 几个状态的变更时间，当order_status = ACTIVATED时 biz_time为设备激活时间，以此类推
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 用户ETC卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 办理人所在地城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 车辆所属企业在支付宝侧入驻的企业id
        /// </summary>
        [XmlElement("corp_id")]
        public string CorpId { get; set; }

        /// <summary>
        /// 用户ETCOBU号
        /// </summary>
        [XmlElement("device_no")]
        public string DeviceNo { get; set; }

        /// <summary>
        /// 车辆发动机号码
        /// </summary>
        [XmlElement("engine_no")]
        public string EngineNo { get; set; }

        /// <summary>
        /// ETC办理激活手机号
        /// </summary>
        [XmlElement("mobile_no")]
        public string MobileNo { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 外部业务号对应该笔ETC申请单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 车牌颜色
        /// </summary>
        [XmlElement("plate_color")]
        public string PlateColor { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("plate_no")]
        public string PlateNo { get; set; }

        /// <summary>
        /// 发行方身份标识
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 核定载人数不带单位
        /// </summary>
        [XmlElement("vi_ac")]
        public long ViAc { get; set; }

        /// <summary>
        /// 行驶证发证日期
        /// </summary>
        [XmlElement("vi_grant_date")]
        public string ViGrantDate { get; set; }

        /// <summary>
        /// 总质量单位kg
        /// </summary>
        [XmlElement("vi_gross_mass")]
        public long ViGrossMass { get; set; }

        /// <summary>
        /// 车高单位mm
        /// </summary>
        [XmlElement("vi_height")]
        public long ViHeight { get; set; }

        /// <summary>
        /// 车长单位mm
        /// </summary>
        [XmlElement("vi_length")]
        public long ViLength { get; set; }

        /// <summary>
        /// 行驶证上的品牌型号
        /// </summary>
        [XmlElement("vi_model_name")]
        public string ViModelName { get; set; }

        /// <summary>
        /// 车主姓名
        /// </summary>
        [XmlElement("vi_owner_name")]
        public string ViOwnerName { get; set; }

        /// <summary>
        /// 车辆注册日期
        /// </summary>
        [XmlElement("vi_register_date")]
        public string ViRegisterDate { get; set; }

        /// <summary>
        /// 车辆VIN码
        /// </summary>
        [XmlElement("vi_vin")]
        public string ViVin { get; set; }

        /// <summary>
        /// 车宽单位mm
        /// </summary>
        [XmlElement("vi_width")]
        public long ViWidth { get; set; }
    }
}
