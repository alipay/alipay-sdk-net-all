using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoContractFormInitializeResponse.
    /// </summary>
    public class AlipayCloudCloudpromoContractFormInitializeResponse : AopResponse
    {
        /// <summary>
        /// 最早起租时间(单位 天)
        /// </summary>
        [XmlElement("earliest_start_time")]
        public long EarliestStartTime { get; set; }

        /// <summary>
        /// 预设的房屋设备列表
        /// </summary>
        [XmlArray("furniture_list")]
        [XmlArrayItem("string")]
        public List<string> FurnitureList { get; set; }

        /// <summary>
        /// 最晚起租时间(单位 天)
        /// </summary>
        [XmlElement("latest_start_time")]
        public long LatestStartTime { get; set; }

        /// <summary>
        /// 最大押金金额 单位：元
        /// </summary>
        [XmlElement("maximum_deposit_amount")]
        public string MaximumDepositAmount { get; set; }

        /// <summary>
        /// 最大租金金额 单位元
        /// </summary>
        [XmlElement("maximum_rent_amount")]
        public string MaximumRentAmount { get; set; }

        /// <summary>
        /// 最大租期（单位月份）
        /// </summary>
        [XmlElement("maximum_rent_period")]
        public long MaximumRentPeriod { get; set; }

        /// <summary>
        /// 支付周期类型
        /// </summary>
        [XmlArray("pay_period_type_list")]
        [XmlArrayItem("rent_contract_dict_vo")]
        public List<RentContractDictVo> PayPeriodTypeList { get; set; }

        /// <summary>
        /// 出租方式
        /// </summary>
        [XmlArray("room_type_list")]
        [XmlArrayItem("rent_contract_dict_vo")]
        public List<RentContractDictVo> RoomTypeList { get; set; }
    }
}
