using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportParkingEnterinfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportParkingEnterinfoSyncModel : AopObject
    {
        /// <summary>
        /// 是否启用车牌代扣状态查询功能，true为启用，false为停用
        /// </summary>
        [XmlElement("agreement_query")]
        public bool AgreementQuery { get; set; }

        /// <summary>
        /// 当前停车场的入场免费时长分钟数
        /// </summary>
        [XmlElement("free_enter_minutes")]
        public string FreeEnterMinutes { get; set; }

        /// <summary>
        /// 车辆入场的时间，格式"YYYY-MM-DD HH:mm:ss"，24小时制，请保证服务器时间准确，入场时间不应晚于当前网络时间
        /// </summary>
        [XmlElement("in_time")]
        public string InTime { get; set; }

        /// <summary>
        /// 车牌是否加密，true为加密，false为不加密，默认为false
        /// </summary>
        [XmlElement("is_encrypt_plate_no")]
        public bool IsEncryptPlateNo { get; set; }

        /// <summary>
        /// 当前行程是否需要计费。true：需要，false：不需要。不传默认为true。
        /// </summary>
        [XmlElement("need_charge")]
        public bool NeedCharge { get; set; }

        /// <summary>
        /// 蚂蚁会员统一ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部停车流水号(用于串通进场与出场信息)
        /// </summary>
        [XmlElement("out_serial_no")]
        public string OutSerialNo { get; set; }

        /// <summary>
        /// 支付宝停车平台ID，由支付宝定义的该停车场标识，同一个isv或商户范围内唯一。通过 alipay.eco.mycar.parking.parkinglotinfo.create (录入停车场信息)接口获取。
        /// </summary>
        [XmlElement("parking_id")]
        public string ParkingId { get; set; }

        /// <summary>
        /// 车牌颜色，车牌颜色，枚举支持： *BLUE：蓝。 *GREEN：绿。 *YELLOW：黄。 *WHITE：白。 *BLACK：黑。 *LIMEGREEN：黄绿色。
        /// </summary>
        [XmlElement("plate_color")]
        public string PlateColor { get; set; }

        /// <summary>
        /// 车牌号（支持加密格式）
        /// </summary>
        [XmlElement("plate_no")]
        public string PlateNo { get; set; }

        /// <summary>
        /// 停车服务页面地址。 1、服务商停车服务页面地址必须是支付宝小程序URL（无需转换https），详见：https://opendocs.alipay.com/support/01rb18#URL%20%E6%A0%BC%E5%BC%8F  2、若服务商没有服务链接，可传输支付宝停车官方小程序的服务链接：alipays://platformapi/startapp?appId=2021001102642986&page=pages%2Fparking-fee%2Findex  3、若此次对接的是无感支付，则服务链接传输为：alipays://platformapi/startapp?appId=2021001102642986&page=%2Fpages%2Fparking-bill%2Findex
        /// </summary>
        [XmlElement("service_url")]
        public string ServiceUrl { get; set; }
    }
}
