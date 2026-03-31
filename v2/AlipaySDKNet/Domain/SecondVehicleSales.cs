using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SecondVehicleSales Data Structure.
    /// </summary>
    [Serializable]
    public class SecondVehicleSales : AopObject
    {
        /// <summary>
        /// 经营、拍卖单位地址
        /// </summary>
        [XmlElement("auction_address")]
        public string AuctionAddress { get; set; }

        /// <summary>
        /// 经营、拍卖单位开户银行、账号
        /// </summary>
        [XmlElement("auction_bank_account")]
        public string AuctionBankAccount { get; set; }

        /// <summary>
        /// 经营、拍卖单位
        /// </summary>
        [XmlElement("auction_company")]
        public string AuctionCompany { get; set; }

        /// <summary>
        /// 经营、拍卖单位电话
        /// </summary>
        [XmlElement("auction_phone")]
        public string AuctionPhone { get; set; }

        /// <summary>
        /// 经营、拍卖单位纳税人识别号
        /// </summary>
        [XmlElement("auction_tax_no")]
        public string AuctionTaxNo { get; set; }

        /// <summary>
        /// 买方单位地址
        /// </summary>
        [XmlElement("buyer_address")]
        public string BuyerAddress { get; set; }

        /// <summary>
        /// 买方电话
        /// </summary>
        [XmlElement("buyer_phone")]
        public string BuyerPhone { get; set; }

        /// <summary>
        /// 买方单位/个人
        /// </summary>
        [XmlElement("buyer_unit")]
        public string BuyerUnit { get; set; }

        /// <summary>
        /// 买方单位代码；税号/身份证号
        /// </summary>
        [XmlElement("buyer_unit_code")]
        public string BuyerUnitCode { get; set; }

        /// <summary>
        /// 车架号
        /// </summary>
        [XmlElement("chassis_no")]
        public string ChassisNo { get; set; }

        /// <summary>
        /// 厂牌型号
        /// </summary>
        [XmlElement("factory_model")]
        public string FactoryModel { get; set; }

        /// <summary>
        /// 车牌照号
        /// </summary>
        [XmlElement("license_plate_no")]
        public string LicensePlateNo { get; set; }

        /// <summary>
        /// 机器编号
        /// </summary>
        [XmlElement("machine_no")]
        public string MachineNo { get; set; }

        /// <summary>
        /// 二手车市场地址
        /// </summary>
        [XmlElement("market_address")]
        public string MarketAddress { get; set; }

        /// <summary>
        /// 二手车市场银行账号
        /// </summary>
        [XmlElement("market_bank_account")]
        public string MarketBankAccount { get; set; }

        /// <summary>
        /// 二手车市场电话
        /// </summary>
        [XmlElement("market_phone")]
        public string MarketPhone { get; set; }

        /// <summary>
        /// 二手车市场税号
        /// </summary>
        [XmlElement("market_tax_no")]
        public string MarketTaxNo { get; set; }

        /// <summary>
        /// 成品油标志
        /// </summary>
        [XmlElement("oil_flag")]
        public string OilFlag { get; set; }

        /// <summary>
        /// 登记证号
        /// </summary>
        [XmlElement("registration_cert_no")]
        public string RegistrationCertNo { get; set; }

        /// <summary>
        /// 二手车市场名称
        /// </summary>
        [XmlElement("second_hand_market")]
        public string SecondHandMarket { get; set; }

        /// <summary>
        /// 卖方单位地址
        /// </summary>
        [XmlElement("seller_address")]
        public string SellerAddress { get; set; }

        /// <summary>
        /// 卖方电话
        /// </summary>
        [XmlElement("seller_phone")]
        public string SellerPhone { get; set; }

        /// <summary>
        /// 卖方单位/个人
        /// </summary>
        [XmlElement("seller_unit")]
        public string SellerUnit { get; set; }

        /// <summary>
        /// 卖方单位代码；税号/身份证
        /// </summary>
        [XmlElement("seller_unit_code")]
        public string SellerUnitCode { get; set; }

        /// <summary>
        /// 通行费标志
        /// </summary>
        [XmlElement("toll_flag")]
        public string TollFlag { get; set; }

        /// <summary>
        /// 转入地车辆管理所名称
        /// </summary>
        [XmlElement("transfer_location")]
        public string TransferLocation { get; set; }

        /// <summary>
        /// 车价合计，单位元
        /// </summary>
        [XmlElement("vehicle_total_price")]
        public string VehicleTotalPrice { get; set; }

        /// <summary>
        /// 车辆类型
        /// </summary>
        [XmlElement("vehicle_type")]
        public string VehicleType { get; set; }

        /// <summary>
        /// 查验时间
        /// </summary>
        [XmlElement("verify_time")]
        public string VerifyTime { get; set; }

        /// <summary>
        /// 零税率标志
        /// </summary>
        [XmlElement("zero_rate_flag")]
        public string ZeroRateFlag { get; set; }
    }
}
