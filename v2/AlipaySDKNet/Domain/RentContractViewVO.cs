using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentContractViewVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentContractViewVO : AopObject
    {
        /// <summary>
        /// 合同id
        /// </summary>
        [XmlElement("contract_id")]
        public string ContractId { get; set; }

        /// <summary>
        /// 合同备注
        /// </summary>
        [XmlElement("contract_notes")]
        public string ContractNotes { get; set; }

        /// <summary>
        /// 押金金额（单位：元 人民币）
        /// </summary>
        [XmlElement("deposit_amount")]
        public string DepositAmount { get; set; }

        /// <summary>
        /// 设备清单
        /// </summary>
        [XmlArray("equipment_list")]
        [XmlArrayItem("rent_house_equipment_v_o")]
        public List<RentHouseEquipmentVO> EquipmentList { get; set; }

        /// <summary>
        /// 房东身份证
        /// </summary>
        [XmlElement("landlord_id_number")]
        public string LandlordIdNumber { get; set; }

        /// <summary>
        /// 房东姓名
        /// </summary>
        [XmlElement("landlord_name")]
        public string LandlordName { get; set; }

        /// <summary>
        /// 房东手机号
        /// </summary>
        [XmlElement("landlord_phone")]
        public string LandlordPhone { get; set; }

        /// <summary>
        /// 支付周期类型
        /// </summary>
        [XmlElement("pay_period_type")]
        public string PayPeriodType { get; set; }

        /// <summary>
        /// 租金金额（单位：元 人民币）
        /// </summary>
        [XmlElement("rent_amount")]
        public string RentAmount { get; set; }

        /// <summary>
        /// 租期 单位：月
        /// </summary>
        [XmlElement("rent_mouth")]
        public long RentMouth { get; set; }

        /// <summary>
        /// 租房开始日期 yyyy-MM-dd
        /// </summary>
        [XmlElement("rent_start_date")]
        public string RentStartDate { get; set; }

        /// <summary>
        /// 租客身份证
        /// </summary>
        [XmlElement("renter_id_number")]
        public string RenterIdNumber { get; set; }

        /// <summary>
        /// 租客姓名
        /// </summary>
        [XmlElement("renter_name")]
        public string RenterName { get; set; }

        /// <summary>
        /// 租客手机号
        /// </summary>
        [XmlElement("renter_phone")]
        public string RenterPhone { get; set; }

        /// <summary>
        /// 房屋地址
        /// </summary>
        [XmlElement("room_address")]
        public string RoomAddress { get; set; }

        /// <summary>
        /// 房屋面积（单位：平方米）
        /// </summary>
        [XmlElement("room_area")]
        public string RoomArea { get; set; }

        /// <summary>
        /// 房间备注
        /// </summary>
        [XmlElement("room_notes")]
        public string RoomNotes { get; set; }

        /// <summary>
        /// 出租方法
        /// </summary>
        [XmlElement("room_rent_type")]
        public string RoomRentType { get; set; }

        /// <summary>
        /// 是否芝麻免押
        /// </summary>
        [XmlElement("support_no_deposit")]
        public bool SupportNoDeposit { get; set; }
    }
}
