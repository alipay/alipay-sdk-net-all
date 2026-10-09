using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanCollateralCarQueryResponse.
    /// </summary>
    public class AlipayPcreditLoanCollateralCarQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户常住地，参考标准的行政区域编号（http://www.stats.gov.cn/tjsj/tjbz/xzqhdm/），如：  330100表示杭州市
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 业务流水号，即用户授信申请的单号，每次授信申请由借呗平台生成的唯一编号，通知估值时给到机构
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 车辆品牌标识，合作机构提供的车型库，如：  1表示奥迪
        /// </summary>
        [XmlElement("car_brand_id")]
        public string CarBrandId { get; set; }

        /// <summary>
        /// 车辆颜色（中文），合作机构提供的颜色范围，如：  米色，棕色，金色，紫色，巧克力色，黑色，蓝色，灰色，绿色，红色，橙色，白色，香槟色，银色，黄色
        /// </summary>
        [XmlElement("car_color")]
        public string CarColor { get; set; }

        /// <summary>
        /// 发动机号
        /// </summary>
        [XmlElement("car_engine_no")]
        public string CarEngineNo { get; set; }

        /// <summary>
        /// 行驶里程数，单位：公里
        /// </summary>
        [XmlElement("car_mileage")]
        public long CarMileage { get; set; }

        /// <summary>
        /// 车型标识，合作机构提供的车型库，如：  1127895表示2017款 奥迪A8L A8L 45 TFSI quattro舒适型
        /// </summary>
        [XmlElement("car_model_id")]
        public string CarModelId { get; set; }

        /// <summary>
        /// 车辆注册日期（行驶证上注册时间），格式：yyyy-MM-dd
        /// </summary>
        [XmlElement("car_reg_date")]
        public string CarRegDate { get; set; }

        /// <summary>
        /// 车系标识，合作机构提供的车型库，如：  10表示奥迪A8L
        /// </summary>
        [XmlElement("car_series_id")]
        public string CarSeriesId { get; set; }

        /// <summary>
        /// 车架号（Vehicle Identification Number，车辆识别代码）
        /// </summary>
        [XmlElement("car_vin")]
        public string CarVin { get; set; }

        /// <summary>
        /// 证件号，查询接口仅提供加密串，算法双方约定
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，和证件号cert_no配合使用，由平台定义，目前支持的证件类型有：  IDENTITY_CARD-身份证
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 押品录入时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("created_time")]
        public string CreatedTime { get; set; }

        /// <summary>
        /// 上牌地，合作机构提供支持办理贷款的省市，参考标准的行政区域编号（http://www.stats.gov.cn/tjsj/tjbz/xzqhdm/），如：  330100表示杭州市
        /// </summary>
        [XmlElement("lic_plate_address")]
        public string LicPlateAddress { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("lic_plate_no")]
        public string LicPlateNo { get; set; }

        /// <summary>
        /// 客户姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
